using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.SuradniciF;

public class VrstaPosla
{
    [Key]
    public int Id { get; set; }

    [Required]
    public List<EvidencijaRadnogVremena> EvidencijaRadnogVremena { get; set; }

}
