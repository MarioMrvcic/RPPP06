using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.SuradniciF;

public class Uloga
{
    [Key]
    public int UlogaId { get; set; }

    [Required]
    public string Ime { get; set; }

    public List<SuradnikUloga>? Suradnici { get; set; }

}
