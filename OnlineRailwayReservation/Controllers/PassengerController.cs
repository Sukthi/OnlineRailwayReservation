using Microsoft.AspNetCore.Mvc;
using OnlineRailwayReservation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineRailwayReservation.Models;
using RailwayReservation.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineRailwayReservation.Controllers
{
    [ApiController]
    [Route("api/passengers")]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerRepository<PassengerDetails> _passengerRepository;

        public PassengerController(IPassengerRepository<PassengerDetails> passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<PassengerDetails> passengers = _passengerRepository.GetAll();
            return Ok(passengers);
        }

        [HttpGet("{passengerId}")]
        public IActionResult Get(int passengerId)
        {
            PassengerDetails passengers = _passengerRepository.Get(passengerId);
            return Ok(passengers);
        }




        [HttpPost]
        public IActionResult Post(PassengerDetails passenger)
        {
            if (passenger == null)
            {
                return BadRequest("passenger is null.");
            }

            _passengerRepository.Add(passenger);

            return Ok(passenger);
        }




        [HttpPut("{id}")]
        public IActionResult Put(int id, PassengerDetails passenger)
        {
            PassengerDetails passengerToUpdate = _passengerRepository.Get(id);
            if (passengerToUpdate == null)
            {
                return NotFound("The customer record couldn't be found.");
            }

            _passengerRepository.Update(passengerToUpdate, passenger);
            return Ok(passengerToUpdate);
            //return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            PassengerDetails passenger = _passengerRepository.Get(id);

            if (passenger == null)
            {
                return NotFound("The passenger record not found.");
            }

            _passengerRepository.Delete(passenger.PassengerId);
            return NoContent();
        }

    }
}

