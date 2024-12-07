using System.ComponentModel.DataAnnotations;

namespace ASPNET12.Models;

public class User
{
    public int Id { get; set; }
    [StringLength(255)]
    public string FirstName { get; set; }
    [StringLength(255)]
    public string LastName { get; set; }
    public int Age { get; set; }
}