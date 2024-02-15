using System.ComponentModel.DataAnnotations;

namespace Contracts;

public class Note
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Value is required")]
    public string Value { get; set; }
    
    [Range(0, 10, ErrorMessage = "Priority must be between 0 and 10")]
    public int Priority { get; set; }
    
}