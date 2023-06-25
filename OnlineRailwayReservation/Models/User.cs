using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    [Required]
    public string Email { get; set; }


    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}

