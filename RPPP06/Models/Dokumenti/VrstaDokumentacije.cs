using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class VrstaDokumentacije
{

    [Key]
    public int VrstaDokumentacijeId { get; set; }

    [Required]
    public string Ime { get; set; }

    [Required]
    public List<DokumentacijaVrstaDokumentacije> Dokumentacija { get; set; }
}
