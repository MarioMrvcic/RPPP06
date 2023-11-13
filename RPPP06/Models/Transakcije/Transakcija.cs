using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPPP06.Models.Transakcije;

public class Transakcija
{
    [Key]
    public int TransakcijaId { get; set; }

    [Required]
    public int IbanIsporučitelja { get; set; }

    [Required]
    public int IbanPrimatelja { get; set; }

    [Required]
    public double Iznos { get ; set; }

    public int? ProjektnaKarticaIsporučiteljId { get; set; }

    public ProjektnaKartica? ProjektnaKarticaIsporučitelj { get; set; }

    public int? ProjektnaKarticaPrimateljId { get; set; }

    public ProjektnaKartica? ProjektnaKarticaPrimatelj { get; set; }

    [Required]
    public VrstaTransakcije VrstaTransakcije { get; set; }

}
