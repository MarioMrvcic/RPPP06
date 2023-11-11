using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class Ugovor
{
    [Key]
    public int Id { get; set; }

    [Required]
    public Dokumentacija Dokumentacija { get; set;}

    [Required]
    public Naručitelj Naručitelj { get; set; }
}
