using OnlineRailwayReservation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using RailwayReservation.Models;

namespace OnlineRailwayReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly RailwayReservationContext _authcontext;

        public RegisterController(RailwayReservationContext railwayContext)
        {
            _authcontext = railwayContext;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObj)
        {
            if (userObj == null)
            {
                return BadRequest();
            }

            var user = await _authcontext.Registration.FirstOrDefaultAsync(x => x.Email == userObj.Email && x.Password == userObj.Password);

            if (user == null)
            {
                return NotFound(new { Message = "User Not Found" });
            }

            return Ok(new { Message = "Login Success" });
        }


        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] Registration registerObj)
        {
            if (registerObj == null)
            {
                return BadRequest();
            }

           

            await _authcontext.Registration.AddAsync(registerObj);
            await _authcontext.SaveChangesAsync();

            return Ok(new
            {
                Message = "User Registered"
            });
        }

    }

}