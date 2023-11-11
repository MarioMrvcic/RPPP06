using RPPP06.Models.Projekti;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class Dokumentacija
{

    [Key] 
    public int Id { get; set; }

    [Required]
    public Projekt Projekt { get; set; }

    [Required]
    public Ugovor Ugovor { get; set; }

    [Required]
    public List<ImaSvoj> Formati { get; set; }

    public List<DijeliSeNa> VrsteDokumentacije { get; set; }

}
