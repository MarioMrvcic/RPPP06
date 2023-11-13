using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class Naručitelj
{
    [Key]
    public int OIB { get; set; }

    [Required]
    public int Iban { get; set; }

    [Required]
    public string Adresa { get; set; }

    public int? Kontakt { get; set; }

    public string? URL { get; set; }

    public List<Ugovor>? Ugovori { get; set; }
}
