using System.Linq;
using OnlineRailwayReservation.Models;
using RailwayReservation.Models;

namespace OnlineRailwayReservation.Repositories
{
    public class UserLoginRepository : IUserRepository<Registration>
    {


        private readonly RailwayReservationContext DBContext;

        public UserLoginRepository(RailwayReservationContext context)
        {
            DBContext = context;
        }
        public void Add(Registration entity)
        {
           DBContext.Registration.Add(entity);
           DBContext.SaveChanges();
        }


        public Registration ValidateAdmin(Registration entity)
        {
            var CurrAdmin = DBContext.Registration.FirstOrDefault
                (
                  Admin => Admin.Email == entity.Email
                  && Admin.Password == entity.Password);


            return CurrAdmin;
        }
    }
}