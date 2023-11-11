using RPPP06.Models.Projekti;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Transakcije;

public class ProjektnaKartica
{
    [Key]
    public int Id { get; set; }

    public String Banka { get; set; }

    [Required]
    public Projekt Projekt { get; set; }

    public List<Transakcija> Transakcije { get; set;}
}
