using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Projekti;

public class VrstaProjekta
{
    [Key]
    public int VrstaProjektaId { get; set; }

    [Required]
    public string Ime { get; set; }

    public List<Projekt>? Projekti { get; set; }
}
