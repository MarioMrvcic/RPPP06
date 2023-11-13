using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.ZadatciF;

public class Status
{

    [Key]
    public int StatusId { get; set; }

    [Required]
    public string Ime { get; set; }

    [Required]
    public string ZastavicaAktivnosti { get; set; }

    public List<Zadatak>? Zadatci { get; set; }

}
