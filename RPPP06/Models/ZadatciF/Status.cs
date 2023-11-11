using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.ZadatciF;

public class Status
{

    [Key]
    public int Id { get; set; }

    [Required]
    public ZastavicaAktivnosti ZastavicaAktivnosti { get; set; }

    public List<Zadatak> Zadatci { get; set; }

}
