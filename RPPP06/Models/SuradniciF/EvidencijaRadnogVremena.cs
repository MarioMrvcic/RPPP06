using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.SuradniciF;

public class EvidencijaRadnogVremena
{

    [Key]
    public int Id { get; set; }

    [Required]
    public VrstaPosla VrstaPosla { get; set; }

    [Required]
    public Suradnik Suradnik { get; set; }

}
