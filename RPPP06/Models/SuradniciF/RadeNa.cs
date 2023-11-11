using RPPP06.Models.Dokumenti;
using RPPP06.Models.Projekti;

namespace RPPP06.Models.SuradniciF;

public class RadeNa
{
    public int ProjektId { get; set; }

    public int SuradnikOIB { get; set; }

    public Projekt Projekt { get; set; } = null!;

    public Suradnik Suradnik { get; set; } = null!;

}
