using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class Ugovor
{
    [Key]
    public int UgovorId { get; set; }

    [Required]
    public int IbanNaručitelja { get; set; }

    [Required]
    public int IbanIsporučitelja { get; set; }

    public int DokumentacijaId { get; set; }
    [Required]
    public Dokumentacija Dokumentacija { get; set;}

    [Required]
    public Naručitelj Naručitelj { get; set; }
}
