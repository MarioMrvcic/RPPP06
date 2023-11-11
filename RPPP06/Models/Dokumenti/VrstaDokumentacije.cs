using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class VrstaDokumentacije
{

    [Key]
    public int Id { get; set; }

    [Required]
    public List<DijeliSeNa> Dokumentacije { get; set; }
}
