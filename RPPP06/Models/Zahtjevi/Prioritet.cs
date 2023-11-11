using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Zahtjevi;

public class Prioritet
{

    [Key]
    public int Id { get; set; }

    public List<Zahtjev> Zahtjevi { get; set; }

}
