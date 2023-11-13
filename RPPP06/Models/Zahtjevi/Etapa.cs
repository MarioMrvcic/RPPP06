using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Zahtjevi;

public class Etapa
{
    [Key]
    public int EtapaId { get; set; }

    [Required]
    public string Ime { get; set; }

    public string? Opis { get; set; }

    [Required]
    public PlanProjekta PlanProjekta { get; set; }

    [Required]
    public Aktivnost Aktivnost { get; set; }

}
