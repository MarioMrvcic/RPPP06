using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class Format
{
    [Key]
    public int Id { get; set; }

    public List<ImaSvoj> Dokumentacije { get; set; }
}
