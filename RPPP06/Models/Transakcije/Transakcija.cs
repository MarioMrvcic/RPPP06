using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Transakcije;

public class Transakcija
{
    [Key]
    public int Id { get; set; }

    [Required]
    public ProjektnaKartica ProjektnaKartica { get; set; }

    [Required]
    public VrstaTransakcije VrstaTransakcije { get; set; }

}
