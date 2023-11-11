using RPPP06.Models.Projekti;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Zahtjevi;

public class PlanProjekta
{
    [Key]
    public int Id { get; set; }

    [Required]
    public Projekt Projekt { get; set; }

    [Required]
    public List<Zahtjev> Zahtjevi { get; set; }

}
