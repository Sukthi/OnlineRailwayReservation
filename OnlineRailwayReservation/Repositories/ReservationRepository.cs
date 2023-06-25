using RailwayReservation.Models;

namespace OnlineRailwayReservation.Repositories
{
    public class ReservationRepository : IPassengerRepository<Reservation>
    {


        private readonly RailwayReservationContext context;

        public ReservationRepository(RailwayReservationContext context)
        {
            this.context = context;
        }

        public void Add(Reservation entity)
        {
            context.Reservations.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int entity)
        {
            Reservation Details = context.Reservations.Find(entity);
            context.Reservations.Remove(Details);
            context.SaveChanges();
        }

        public Reservation Get(int passengerId)
        {
            return context.Reservations.Find(passengerId);
        }


        public IEnumerable<Reservation> GetAll()
        {
            return context.Reservations.ToList();
        }

        public IEnumerable<Reservation> GetByPassenger(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation dbEntity, Reservation entity)
        {
            
            dbEntity.SeatNumber = entity.SeatNumber;
            dbEntity.ReservationDate = entity.ReservationDate;
            dbEntity.PassengerDetails = entity.PassengerDetails;
            dbEntity.TrainDetails = entity.TrainDetails;

            context.SaveChanges();
        }
    }
}

