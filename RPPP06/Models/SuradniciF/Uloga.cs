using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.SuradniciF;

public class Uloga
{
    [Key]
    public int Id { get; set; }

    public List<Ima> Suradnici { get; set; }

}
