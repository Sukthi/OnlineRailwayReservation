using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineRailwayReservation.Models;
using OnlineRailwayReservation.Repositories;

namespace OnlineRailwayReservation.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository<Admin> _context;

        public AdminController(IAdminRepository<Admin> context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult VerifyAdmin(Admin model)
        {
            var currentAdmin = _context.ValidateAdmin(model);
            if (currentAdmin == null)
                return NotFound("User Not Found");
            return Ok(currentAdmin);

        }

    }
}