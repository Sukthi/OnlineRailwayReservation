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
    [Route("api/reservation")]
    public class ReservationController : ControllerBase
    {
        private readonly IPassengerRepository<Reservation> _reservationRepository;

        public ReservationController(IPassengerRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Reservation> customers = _reservationRepository.GetAll();
            return Ok(customers);
        }

        [HttpGet("{passengerId}")]
        public IActionResult Get(int passengerId)
        {
            Reservation customers = _reservationRepository.Get(passengerId);
            return Ok(customers);
        }




        [HttpPost]
        public IActionResult Post(Reservation passenger)
        {
            if (passenger == null)
            {
                return BadRequest("passenger is null.");
            }

            _reservationRepository.Add(passenger);

            return Ok(passenger);
        }




        [HttpPut("{id,customer}")]
        public IActionResult Put(int id, Reservation passenger)
        {
            Reservation passengerToUpdate = _reservationRepository.Get(id);
            if (passengerToUpdate == null)
            {
                return NotFound("The customer record couldn't be found.");
            }

            _reservationRepository.Update(passengerToUpdate, passenger);
            return Ok(passengerToUpdate);
            //return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Reservation passenger = _reservationRepository.Get(id);

            if (passenger == null)
            {
                return NotFound("The passenger record not found.");
            }

            _reservationRepository.Delete(passenger.PassengerId);
            return NoContent();
        }

    }
}

