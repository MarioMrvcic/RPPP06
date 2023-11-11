using RPPP06.Models.SuradniciF;
using RPPP06.Models.Zahtjevi;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.ZadatciF;

public class Zadatak
{
    [Key]
    public int ŠifZad { get; set; }

    [Required]
    public Zahtjev Zahtjev { get; set; }

    public Nositelj Nositelj { get; set; }

    [Required]
    public Status Status { get; set; }

    public Suradnik Suradnik { get; set;}
}