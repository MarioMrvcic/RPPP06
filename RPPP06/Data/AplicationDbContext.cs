using Microsoft.EntityFrameworkCore;
using RPPP06.Models.Dokumenti;
using RPPP06.Models.Projekti;
using RPPP06.Models.SuradniciF;
using RPPP06.Models.Transakcije;
using RPPP06.Models.Zahtjevi;

namespace RPPP06.Data;

public class AplicationDbContext : DbContext
{

    public AplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Projekt> Projekt { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Dokumenti
        modelBuilder.Entity<ImaSvoj>().HasKey(cp => new { cp.DokumentacijaId, cp.FormatId });
        modelBuilder.Entity<Dokumentacija>().HasMany(c => c.Formati).WithOne(c => c.Dokumentacija).HasForeignKey(c => c.DokumentacijaId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Format>().HasMany(c => c.Dokumentacije).WithOne(c => c.Format).HasForeignKey(c => c.FormatId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<DijeliSeNa>().HasKey(cp => new { cp.DokumentacijaId, cp.VrstaDokumentacijeId });
        modelBuilder.Entity<Dokumentacija>().HasMany(c => c.VrsteDokumentacije).WithOne(c => c.Dokumentacija).HasForeignKey(c => c.DokumentacijaId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<VrstaDokumentacije>().HasMany(c => c.Dokumentacije).WithOne(c => c.VrstaDokumentacije).HasForeignKey(c => c.VrstaDokumentacijeId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Dokumentacija>().HasOne(d => d.Ugovor).WithOne(u => u.Dokumentacija).HasForeignKey<Ugovor>(u => u.Id).IsRequired();
        modelBuilder.Entity<Ugovor>().HasOne(u => u.Dokumentacija).WithOne(d => d.Ugovor).IsRequired();

        modelBuilder.Entity<Projekt>().HasOne(u => u.Dokumentacija).WithOne(d => d.Projekt).HasForeignKey<Dokumentacija>(u => u.Id).IsRequired();
        modelBuilder.Entity<Dokumentacija>().HasOne(d => d.Projekt).WithOne(u => u.Dokumentacija);

        //Transakcije
        modelBuilder.Entity<Projekt>().HasOne(u => u.ProjektnaKartica).WithOne(d => d.Projekt).HasForeignKey<ProjektnaKartica>(u => u.Id).IsRequired();
        modelBuilder.Entity<ProjektnaKartica>().HasOne(d => d.Projekt).WithOne(u => u.ProjektnaKartica).IsRequired();

        //Zahtjevi
        modelBuilder.Entity<Projekt>().HasOne(u => u.PlanProjekta).WithOne(d => d.Projekt).HasForeignKey<PlanProjekta>(u => u.Id).IsRequired();
        modelBuilder.Entity<PlanProjekta>().HasOne(d => d.Projekt).WithOne(u => u.PlanProjekta).IsRequired();

        //Zadatci
        modelBuilder.Entity<RadeNa>().HasKey(cp => new { cp.SuradnikOIB, cp.ProjektId });
        modelBuilder.Entity<Projekt>().HasMany(c => c.Suradnici).WithOne(c => c.Projekt).HasForeignKey(c => c.SuradnikOIB).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Suradnik>().HasMany(c => c.Projekti).WithOne(c => c.Suradnik).HasForeignKey(c => c.ProjektId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Ima>().HasKey(cp => new { cp.SuradnikOIB, cp.UlogaId });
        modelBuilder.Entity<Uloga>().HasMany(c => c.Suradnici).WithOne(c => c.Uloga).HasForeignKey(c => c.SuradnikOIB).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Suradnik>().HasMany(c => c.Uloge).WithOne(c => c.Suradnik).HasForeignKey(c => c.UlogaId).OnDelete(DeleteBehavior.Cascade);
    }
}
