using RPPP06.Models.Dokumenti;
using RPPP06.Models.Projekti;

namespace RPPP06.Models.SuradniciF;

public class SuradnikProjekt
{
    public int ProjektId { get; set; }

    public string SuradnikEmail { get; set; }

    public Projekt Projekt { get; set; } = null!;

    public Suradnik Suradnik { get; set; } = null!;

}
