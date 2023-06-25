namespace RailwayReservation.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int PassengerId { get; set; }
        public int TrainId { get; set; }
        public string SeatNumber { get; set; }
        public DateTime ReservationDate { get; set; }

        // Navigation properties for relationships
        public PassengerDetails PassengerDetails { get; set; }
        public TrainDetails TrainDetails { get; set; }
    }
}
