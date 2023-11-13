using RPPP06.Models.Projekti;
using RPPP06.Models.ZadatciF;
using RPPP06.Models.Zahtjevi;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.SuradniciF;

public class Suradnik
{
    [Key]
    public string Email { get; set; }

    [Required]
    public string Ime { get; set; }

    [Required]
    public string Prezime { get; set; }

    [Required]
    public string MjestoStanovanja { get; set; }

    [Required]
    public int BrojTelefona { get; set; }

    public string? URL { get; set; }

    [Required]
    public List<Zadatak> Zadatci { get; set; }

    public List<SuradnikProjekt>? Projekti { get; set; }

    [Required]
    public List<SuradnikUloga> Uloge { get; set; }

    public Suradnik? Nadređeni { get; set; }

    public List<Posao>? Poslovi { get; set; }

    public List<PlanProjekta>? PlanoviProjekta { get; set; }

}
