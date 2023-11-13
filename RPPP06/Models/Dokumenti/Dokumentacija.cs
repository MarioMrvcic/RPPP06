using RPPP06.Models.Projekti;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Dokumenti;

public class Dokumentacija
{

    [Key] 
    public int DokumentacijaId { get; set; }

    [Required]
    public string NazivDokumentacije { get; set; }

    public DateTime? VrijemeKreacije { get; set; }

    public string? Format { get; set; }

    [Required]
    public string URL { get; set; }

    public string? StatusDovršenosti { get; set; }

    public int ProjektId { get; set; }
    [Required]
    public Projekt Projekt { get; set; }

    [Required]
    public Ugovor Ugovor { get; set; }

    public List<DokumentacijaVrstaDokumentacije>? VrsteDokumentacije { get; set; }

}
