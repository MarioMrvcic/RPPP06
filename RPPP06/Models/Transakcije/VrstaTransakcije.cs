using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Transakcije;

public class VrstaTransakcije
{

    [Key]
    public int Id { get; set; }

    public List<Transakcija> Transakcije { get; set;}
}
