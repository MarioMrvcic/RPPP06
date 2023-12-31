﻿using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Zahtjevi;

public class Prioritet
{

    [Key]
    public int PrioritetId { get; set; }

    [Required]
    public string Ime { get; set; }

    public List<Zahtjev>? Zahtjevi { get; set; }

}
