using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class ProcedureDTO
{
    [Required] 
    public int Id { get; set; }
    [Required]
    [MaxLength (100)]
    public string Name { get; set; }
    [Required]
    [MaxLength (100)]
    public string Description {get;set; }
}