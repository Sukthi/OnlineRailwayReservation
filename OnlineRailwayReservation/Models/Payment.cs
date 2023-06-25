using RailwayReservation.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineRailwayReservation.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ReservationId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

   
        // Navigation property
        public Reservation Reservation { get; set; }
    }
}