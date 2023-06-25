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
    [Route("api/traindetails")]
    public class TrainDetailsController : ControllerBase
    {
        private readonly IPassengerRepository<TrainDetails> _trainRepository;

        public TrainDetailsController(IPassengerRepository<TrainDetails> trainRepository)
        {
            _trainRepository = trainRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<TrainDetails> customers = _trainRepository.GetAll();
            return Ok(customers);
        }

        [HttpGet("{passengerId}")]
        public IActionResult Get(int passengerId)
        {
            TrainDetails customers = _trainRepository.Get(passengerId);
            return Ok(customers);
        }




        [HttpPost]
        public IActionResult Post(TrainDetails passenger)
        {
            if (passenger == null)
            {
                return BadRequest("passenger is null.");
            }

            _trainRepository.Add(passenger);

            return Ok(passenger);
        }




        [HttpPut("{id}")]
        public IActionResult Put(int id, TrainDetails passenger)
        {
            TrainDetails passengerToUpdate = _trainRepository.Get(id);
            if (passengerToUpdate == null)
            {
                return NotFound("The customer record couldn't be found.");
            }

            _trainRepository.Update(passengerToUpdate, passenger);
            return Ok(passengerToUpdate);
            //return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            TrainDetails passenger = _trainRepository.Get(id);

            if (passenger == null)
            {
                return NotFound("The passenger record not found.");
            }

            _trainRepository.Delete(passenger.TrainId);
            return NoContent();
        }

    }
}

