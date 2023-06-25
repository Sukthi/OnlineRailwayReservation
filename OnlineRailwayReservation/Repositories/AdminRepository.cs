using System.Collections.Generic;
using System.Linq;
using OnlineRailwayReservation.Models;
using RailwayReservation.Models;

namespace OnlineRailwayReservation.Repositories
{
    public class AdminRepository : IAdminRepository<Admin>
    {
        private readonly RailwayReservationContext _context;

        public AdminRepository(RailwayReservationContext context)
        {
            _context = context;
        }
        public void Add(Admin entity)
    {
        _context.Admin.Add(entity);
        _context.SaveChanges();
    }


    public Admin ValidateAdmin(Admin entity)
    {
        var CurrAdmin = _context.Admin.FirstOrDefault
            (
              Admin => Admin.AdminEmail == entity.AdminEmail
              && Admin.Password == entity.Password);


        return CurrAdmin;
    }

}
    }
