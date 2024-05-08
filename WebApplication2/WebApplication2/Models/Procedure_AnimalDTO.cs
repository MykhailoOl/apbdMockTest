using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class Procedure_AnimalDTO
{
    [Required] 
    public int Procedute_Id { get; set; }
    [Required]
    public int Animal_Id { get; set; }
    [Required] 
    public DateTime Date { get; set; }
}