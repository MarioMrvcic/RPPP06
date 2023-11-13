using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Zahtjevi;

public class TipZahtjeva
{
    [Key]
    public int TipZahtjevaId { get; set; }

    [Required]
    public string Ime { get; set; }

    public List<Zahtjev>? Zahtjevi { get; set; }
}
