using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.ZadatciF;

public class Nositelj
{

    [Key]
    public int Id { get; set; }

    public List<Zadatak> Zadatci { get; set; }

}
