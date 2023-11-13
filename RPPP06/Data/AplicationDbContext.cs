using Microsoft.EntityFrameworkCore;
using RPPP06.Models.Dokumenti;
using RPPP06.Models.Projekti;
using RPPP06.Models.SuradniciF;
using RPPP06.Models.Transakcije;
using RPPP06.Models.ZadatciF;
using RPPP06.Models.Zahtjevi;
using System.Reflection.Metadata;

namespace RPPP06.Data;

public class AplicationDbContext : DbContext
{

    public AplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Dokumentacija> Dokumentacija { get; set; }
    public DbSet<DokumentacijaVrstaDokumentacije> DokumentacijaVrstaDokumentacije { get; set; }
    public DbSet<Naručitelj> Naručitelj { get; set; }
    public DbSet<Ugovor> Ugovor { get; set; }
    public DbSet<VrstaDokumentacije> VrstaDokumentacije { get; set; }
    public DbSet<Projekt> Projekt { get; set; }
    public DbSet<VrstaProjekta> VrstaProjekta { get; set; }
    public DbSet<Posao> Posao { get; set; }
    public DbSet<Suradnik> Suradnik { get; set; }
    public DbSet<SuradnikProjekt> SuradnikProjekt { get; set; }
    public DbSet<SuradnikUloga> SuradnikUloga { get; set; }
    public DbSet<Uloga> Uloga { get; set; }
    public DbSet<VrstaPosla> VrstaPosla { get; set; }
    public DbSet<ProjektnaKartica> ProjektnaKartica { get; set; }
    public DbSet<Transakcija> Transakcija { get; set; }
    public DbSet<VrstaTransakcije> VrstaTransakcije { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Zadatak> Zadatak { get; set; }
    public DbSet<Aktivnost> Aktivnost { get; set; }
    public DbSet<Etapa> Etapa { get; set; }
    public DbSet<PlanProjekta> PlanProjekta { get; set; }
    public DbSet<Prioritet> Prioritet { get; set; }
    public DbSet<TipZahtjeva> TipZahtjeva { get; set; }
    public DbSet<Zahtjev> Zahtjev { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Projekt>().HasData(DataBaseInitialization.ReturnProjekt());

        //Dokumenti
        modelBuilder.Entity<DokumentacijaVrstaDokumentacije>().HasKey(cp => new { cp.DokumentacijaId, cp.VrstaDokumentacijeId });
        modelBuilder.Entity<Dokumentacija>().HasMany(c => c.VrsteDokumentacije).WithOne(c => c.Dokumentacija).HasForeignKey(c => c.DokumentacijaId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<VrstaDokumentacije>().HasMany(c => c.Dokumentacija).WithOne(c => c.VrstaDokumentacije).HasForeignKey(c => c.VrstaDokumentacijeId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Projekt>()
        .HasOne(e => e.Dokumentacija)
        .WithOne(e => e.Projekt)
        .HasForeignKey<Dokumentacija>(e => e.ProjektId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Dokumentacija>()
        .HasOne(e => e.Ugovor)
        .WithOne(e => e.Dokumentacija)
        .HasForeignKey<Ugovor>(e => e.DokumentacijaId)
        .OnDelete(DeleteBehavior.Cascade);

        //Transakcije
        modelBuilder.Entity<Transakcija>()
            .HasOne(t => t.ProjektnaKarticaIsporučitelj)
            .WithMany()
            .HasForeignKey(t => t.ProjektnaKarticaIsporučiteljId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Transakcija>()
            .HasOne(t => t.ProjektnaKarticaPrimatelj)
            .WithMany()
            .HasForeignKey(t => t.ProjektnaKarticaPrimateljId)
            .OnDelete(DeleteBehavior.Restrict);

        //Zahtjevi
        modelBuilder.Entity<Projekt>()
        .HasOne(e => e.PlanProjekta)
        .WithOne(e => e.Projekt)
        .HasForeignKey<PlanProjekta>(e => e.ProjektId)
        .OnDelete(DeleteBehavior.Cascade);

        //Zadatci
        modelBuilder.Entity<SuradnikProjekt>()
            .HasKey(sp => new { sp.SuradnikEmail, sp.ProjektId });
        modelBuilder.Entity<SuradnikProjekt>()
            .HasOne(sp => sp.Suradnik)
            .WithMany(s => s.Projekti)
            .HasForeignKey(sp => sp.SuradnikEmail);
        modelBuilder.Entity<SuradnikProjekt>()
            .HasOne(sp => sp.Projekt)
            .WithMany(p => p.Suradnici)
            .HasForeignKey(sp => sp.ProjektId);

        modelBuilder.Entity<SuradnikUloga>()
            .HasKey(sp => new { sp.SuradnikEmail, sp.UlogaId });
        modelBuilder.Entity<SuradnikUloga>()
            .HasOne(sp => sp.Suradnik)
            .WithMany(s => s.Uloge)
            .HasForeignKey(sp => sp.SuradnikEmail);
        modelBuilder.Entity<SuradnikUloga>()
            .HasOne(sp => sp.Uloga)
            .WithMany(p => p.Suradnici)
            .HasForeignKey(sp => sp.UlogaId);

        // Configure the Zadatak-Posao relationship
        modelBuilder.Entity<Posao>()
            .HasOne(p => p.Zadatak)
            .WithMany(z => z.Poslovi)
            .HasForeignKey(p => p.ZadatakId)
            .OnDelete(DeleteBehavior.Restrict); // You can use other behaviors based on your requirements

        // Configure the Posao-Suradnik relationship
        modelBuilder.Entity<Posao>()
            .HasOne(p => p.Suradnik)
            .WithMany(s => s.Poslovi)
            .HasForeignKey(p => p.SuradnikEmail)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
