using RPPP06.Models.Projekti;

namespace RPPP06.Models.SuradniciF;

public class Ima
{
    public int UlogaId { get; set; }

    public int SuradnikOIB { get; set; }

    public Uloga Uloga { get; set; } = null!;

    public Suradnik Suradnik { get; set; } = null!;
}
