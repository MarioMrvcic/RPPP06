using RPPP06.Models.Dokumenti;
using RPPP06.Models.SuradniciF;
using RPPP06.Models.Transakcije;
using RPPP06.Models.Zahtjevi;
using System.ComponentModel.DataAnnotations;

namespace RPPP06.Models.Projekti
{
    public class Projekt
    {

        [Key]
        public int SifProjekt { get; set; }

        public Dokumentacija Dokumentacija { get; set; }

        [Required]
        public ProjektnaKartica ProjektnaKartica { get; set; }

        [Required]
        public PlanProjekta PlanProjekta { get; set;}

        [Required]
        public List<RadeNa> Suradnici { get; set; }

    }
}
