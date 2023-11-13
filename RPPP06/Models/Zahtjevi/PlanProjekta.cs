using RPPP06.Models.Projekti;
using RPPP06.Models.SuradniciF;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace RPPP06.Models.Zahtjevi;

public class PlanProjekta
{
    [Key]
    public int PlanProjektaId { get; set; }

    [Required]
    public DateTime PlaniraniPočetak { get; set; }

    [Required]
    public DateTime PlaniraniKraj { get; set; }

    public DateTime? StvarniPočetak { get; set; }

    public DateTime? StvarniKraj { get; set; }

    public int ProjektId { get; set; }
    [Required]
    public Projekt Projekt { get; set; }

    [Required]
    public List<Zahtjev> Zahtjevi { get; set; }

    [Required]
    public List<Etapa> Etape { get; set; }

    [Required]
    public Suradnik Voditelj { get; set; }

}
