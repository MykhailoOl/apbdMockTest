using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class AnimalDTO
{
    [Required] 
    public int Id { get; set; }
    [Required] 
    [MaxLength (100)]
    public string Name { get; set; }
    [Required] 
    [MaxLength (100)]
    public string Type { get; set; }
    [Required]
    public DateTime AdmissionDate { get; set; }
    [Required]
    public int Owner_Id { get; set; }
}