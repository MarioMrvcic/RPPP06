using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Transakcije;

public class VrstaTransakcije
{

    [Key]
    public int VrstaTransakcijeId { get; set; }

    [Required]
    public String Ime { get; set; }

    public List<Transakcija>? Transakcije { get; set;}
}
