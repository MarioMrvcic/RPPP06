using RPPP06.Models.ZadatciF;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPPP06.Models.SuradniciF;

public class Posao
{

    [Key]
    public int PosaoId { get; set; }

    public string? Opis { get; set; }

    [Required]
    public DateTime VrijemePočetkaRada { get; set; }

    [Required]
    public DateTime VrijemeKrajaRada { get; set; }

    public int ZadatakId { get; set; }
    [Required]
    public Zadatak Zadatak { get; set; }

    [Required]
    public VrstaPosla VrstaPosla { get; set; }

    public string SuradnikEmail { get; set; }
    [Required]
    public Suradnik Suradnik { get; set; }

}
