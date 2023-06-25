using RailwayReservation.Models;

namespace OnlineRailwayReservation.Repositories
{
    public class TrainDetailsRepository: IPassengerRepository<TrainDetails>
    {
 

        private readonly RailwayReservationContext context;

        public TrainDetailsRepository(RailwayReservationContext context)
        {
            this.context = context;
        }
        public void Add(TrainDetails entity)
        {
            context.Trains.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int entity)
        {
            TrainDetails Details = context.Trains.Find(entity);
            context.Trains.Remove(Details);
            context.SaveChanges();
        }

        public PassengerDetails Get(int accnum)
        {
            return context.Passengers.Find(accnum);
        }


        public IEnumerable<TrainDetails> GetAll()
        {
            return context.Trains.ToList();
        }

        public IEnumerable<TrainDetails> GetByPassenger(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TrainDetails dbEntity, TrainDetails entity)
        {
            //dbEntity.AccountNumber = entity.AccountNumber;

            dbEntity.TrainName = entity.TrainName;
            dbEntity.DepartureStation = entity.DepartureStation;
            dbEntity.ArrivalStation = entity.ArrivalStation;
            dbEntity.DepartureTime = entity.DepartureTime;
            dbEntity.ArrivalTime = entity.ArrivalTime;


            context.SaveChanges();
        }

        TrainDetails IPassengerRepository<TrainDetails>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}


