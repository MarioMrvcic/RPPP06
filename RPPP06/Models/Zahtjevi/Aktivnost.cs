using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Zahtjevi;

public class Aktivnost
{

    [Key]
    public int AktivnostId { get; set; }

    [Required]
    public string Ime { get; set; }

    public List<Etapa>? Etapa { get; set; }

}
