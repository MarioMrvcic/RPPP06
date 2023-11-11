namespace RPPP06.Models.Dokumenti;

public class ImaSvoj
{

    public int DokumentacijaId { get; set; }

    public int FormatId { get; set; }

    public Dokumentacija Dokumentacija { get; set; } = null!;

    public Format Format { get; set; } = null!;

}
