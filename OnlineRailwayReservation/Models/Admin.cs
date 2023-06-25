using System.ComponentModel.DataAnnotations;

namespace OnlineRailwayReservation.Models
{
    public class Admin
    {

        [Key]
        public int AdminID { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string AdminEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
