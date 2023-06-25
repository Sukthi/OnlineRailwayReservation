
using System;

namespace RailwayReservation.Models
{
    public class TrainDetails
    {
        
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}