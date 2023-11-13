using RPPP06.Models.Projekti;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Transakcije;

public class ProjektnaKartica
{
    [Key]
    public int ProjektnaKarticaId { get; set; }

    [Required]
    public String Banka { get; set; }

    [Required]
    public int Iban { get; set; }

    [Required]
    public double Stanje { get; set; }

    [Required]
    public Projekt Projekt { get; set; }
}
