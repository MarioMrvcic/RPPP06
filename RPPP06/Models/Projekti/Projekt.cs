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
        public int ProjektId { get; set; }

        [Required]
        public string Ime { get; set; }

        public string? Kratica { get; set; }

        public string? Opis { get; set; }

        [Required]
        public DateTime PlaniraniPočetak { get; set; }

        [Required]
        public DateTime PlaniraniKraj { get; set; }

        public DateTime? StvarniPočetak { get; set; }

        public DateTime? StvarniKraj { get; set; }

        public Dokumentacija? Dokumentacija { get; set; }

        [Required]
        public List<ProjektnaKartica> ProjektneKartice { get; set; }

        [Required]
        public PlanProjekta PlanProjekta { get; set;}

        [Required]
        public List<SuradnikProjekt> Suradnici { get; set; }

        [Required]
        public VrstaProjekta VrstaProjekta { get; set; }
    }
}
