//using System.Collections.Generic;
//using System.Linq;
//using OnlineRailwayReservation.Models;
//using RailwayReservation.Models;

//namespace OnlineRailwayReservation.Repositories
//{
//    public class RegistrationRepository : IRegistrationRespository
//    {
//        private readonly RailwayReservationContext _context;

//        public RegistrationRepository(RailwayReservationContext context)
//        {
//            _context = context;
//        }

//        public IEnumerable<Registration> GetAllRegistrations()
//        {
//            return _context.Registration.ToList();
//        }

//        public Registration GetRegistrationById(int id)
//        {
//            return _context.Registration.FirstOrDefault(r => r.Id == id);
//        }

//        public void AddRegistration(Registration registration)
//        {
//            _context.Registration.Add(registration);
//            _context.SaveChanges();
//        }

//        public void UpdateRegistration(Registration registration)
//        {
//            _context.Registration.Update(registration);
//            _context.SaveChanges();
//        }

//        public void DeleteRegistration(Registration registration)
//        {
//            _context.Registration.Remove(registration);
//            _context.SaveChanges();
//        }
//    }
//}
