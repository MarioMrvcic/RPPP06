using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class Naručitelj
{
    [Key]
    public int Id { get; set; }

    public List<Ugovor> Ugovori { get; set; }
}
