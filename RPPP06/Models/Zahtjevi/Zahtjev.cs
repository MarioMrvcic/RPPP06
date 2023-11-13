using RPPP06.Models.ZadatciF;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Zahtjevi;

public class Zahtjev
{
    [Key]
    public int ZahtjevId { get; set; }

    [Required]
    public string Ime { get; set; }

    public string? Opis { get; set; }

    [Required]
    public PlanProjekta PlanProjekta { get; set; }

    [Required]
    public Prioritet Prioritet { get; set; }

    [Required]
    public TipZahtjeva TipZahtjeva { get; set; }

    [Required]
    public List<Zadatak> Zadatci { get; set; }
}
