using RPPP06.Models.SuradniciF;
using RPPP06.Models.Zahtjevi;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.ZadatciF;

public class Zadatak
{
    [Key]
    public int ZadatakId { get; set; }

    public string? OpisZadatka { get; set; }

    [Required]
    public DateTime PlaniraniPočetak { get; set; }

    [Required]
    public DateTime PlaniraniKraj { get; set; }

    public DateTime? StvarniPočetak { get; set; }

    public DateTime? StvarniKraj { get; set; }

    [Required]
    public Zahtjev Zahtjev { get; set; }

    [Required]
    public Status Status { get; set; }

    public Suradnik? Nositelj { get; set;}

    public List<Posao>? Poslovi { get; set; }
}