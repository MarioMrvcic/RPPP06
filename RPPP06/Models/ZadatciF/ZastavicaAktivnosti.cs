using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.ZadatciF;

public class ZastavicaAktivnosti
{
    [Key]
    public int Id { get; set; }

    public List<Status> Statusi { get; set; }

}
