using RPPP06.Models.Projekti;

namespace RPPP06.Models.SuradniciF;

public class SuradnikUloga
{
    public int UlogaId { get; set; }

    public string SuradnikEmail { get; set; }

    public Uloga Uloga { get; set; } = null!;

    public Suradnik Suradnik { get; set; } = null!;
}
