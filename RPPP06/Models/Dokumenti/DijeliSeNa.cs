namespace RPPP06.Models.Dokumenti;

public class DijeliSeNa
{
    public int DokumentacijaId { get; set; }

    public int VrstaDokumentacijeId { get; set; }

    public Dokumentacija Dokumentacija { get; set; } = null!;

    public VrstaDokumentacije VrstaDokumentacije { get; set; } = null!;
}
