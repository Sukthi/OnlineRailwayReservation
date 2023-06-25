using RailwayReservation.Models;
using System.Collections.Generic;
using System.Linq;


namespace OnlineRailwayReservation.Repositories
{
    public class SqlPassengerRepository : IPassengerRepository<PassengerDetails>
    {
        private readonly RailwayReservationContext context;

        public SqlPassengerRepository(RailwayReservationContext context )
        {
            this.context = context;
        }
        public void Add(PassengerDetails entity)
        {
            context.Passengers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int entity)
        {
            PassengerDetails Details = context.Passengers.Find(entity);
            context.Passengers.Remove(Details);
            context.SaveChanges();
        }

        public PassengerDetails Get(int accnum)
        {
            return context.Passengers.Find(accnum);
        }


        public IEnumerable<PassengerDetails> GetAll()
        {
            return context.Passengers.ToList();
        }

        public IEnumerable<PassengerDetails> GetByPassenger(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PassengerDetails dbEntity, PassengerDetails entity)
        {
            //dbEntity.AccountNumber = entity.AccountNumber;
            
            dbEntity.Name = entity.Name;
            dbEntity.PhoneNumber = entity.PhoneNumber;
            dbEntity.Email= entity.Email;
            dbEntity.DateOfBirth = entity.DateOfBirth;
         
            context.SaveChanges();
        }
    }
}


