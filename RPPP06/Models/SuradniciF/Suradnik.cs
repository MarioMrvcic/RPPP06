using RPPP06.Models.Projekti;
using RPPP06.Models.ZadatciF;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.SuradniciF;

public class Suradnik
{
    [Key]
    public int OIB { get; set; }

    [Required]
    public List<Zadatak> Zadatci { get; set; }

    public List<RadeNa> Projekti { get; set; }

    [Required]
    public List<Ima> Uloge { get; set; }

    public List<Suradnik> Nadređeni { get; set; }

    public List<EvidencijaRadnogVremena> EvidencijeRadnogVremena { get; set; }

}
