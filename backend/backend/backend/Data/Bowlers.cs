using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace backend.Data;

public class Bowlers
{
    [Key]
    public int BowlerID { get; set; }
    [Required] 
    public string BowlerLastName { get; set; }
    [Required]
    public string BowlerFirstName { get; set; }
 
    public string? BowlerMiddleInit { get; set; }
    public string BowlerAddress { get; set; }
    public int TeamID { get; set; }
    public string BowlerCity { get; set; }
    public string BowlerState { get; set; }
    public string BowlerZip { get; set; }
    public string BowlerPhoneNumber { get; set; }
}