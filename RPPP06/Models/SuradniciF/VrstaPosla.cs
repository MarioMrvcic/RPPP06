using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.SuradniciF;

public class VrstaPosla
{
    [Key]
    public int VrstaPoslaId { get; set; }

    [Required]
    public string Ime { get; set; }

    [Required]
    public List<Posao> Poslovi { get; set; }

}
