using RPPP06.Models.Dokumenti;
using RPPP06.Models.Projekti;
using RPPP06.Models.SuradniciF;
using RPPP06.Models.Transakcije;
using RPPP06.Models.ZadatciF;
using RPPP06.Models.Zahtjevi;

namespace RPPP06.Data;

public class DataBaseInitialization
{
    public static List<VrstaTransakcije>  ReturnTransakcije()
    {
        List<VrstaTransakcije> _vrstaTransakcije = new List<VrstaTransakcije>(){
            new VrstaTransakcije() { VrstaTransakcijeId=1, Ime="Uplata"},
            new VrstaTransakcije() { VrstaTransakcijeId=2, Ime="Isplata"},
            new VrstaTransakcije() { VrstaTransakcijeId=3, Ime="Honorar"},
            new VrstaTransakcije() { VrstaTransakcijeId=4, Ime="Prijenos"},
        };

        return _vrstaTransakcije;
    }

    public static List<VrstaDokumentacije> ReturnDokumentacija()
    {
        List<VrstaDokumentacije> _vrstaDokumentacije = new List<VrstaDokumentacije>(){
            new VrstaDokumentacije() { VrstaDokumentacijeId=1, Ime="Ponuda"},
            new VrstaDokumentacije() { VrstaDokumentacijeId=2, Ime="Ugovor"},
            new VrstaDokumentacije() { VrstaDokumentacijeId=3, Ime="Dokumentacija izvedenog stanja"},

        };

        return _vrstaDokumentacije;
    }

    public static List<VrstaPosla> ReturnPosao()
    {
        List<VrstaPosla> _vrstaPosao = new List<VrstaPosla>(){
            new VrstaPosla() { VrstaPoslaId=1, Ime="Analiza"},
            new VrstaPosla() { VrstaPoslaId=2, Ime="Projektiranje"},
            new VrstaPosla() { VrstaPoslaId=3, Ime="Programiranje"},
            new VrstaPosla() { VrstaPoslaId=4, Ime="Testiranje"},
            new VrstaPosla() { VrstaPoslaId=5, Ime="Dokumentiranje"},
            new VrstaPosla() { VrstaPoslaId=6, Ime="Planiranje"},
        };

        return _vrstaPosao;
    }

    public static List<Uloga> ReturnUloga()
    {
        List<Uloga> _uloga = new List<Uloga>(){
            new Uloga() { UlogaId=1, Ime="Sistem analitičar"},
            new Uloga() { UlogaId=2, Ime="Programer"},
            new Uloga() { UlogaId=3, Ime="Sponzor"},
            new Uloga() { UlogaId=4, Ime="Tester"},
            new Uloga() { UlogaId=5, Ime="Koordinator"},
            new Uloga() { UlogaId=6, Ime="Analiza"},
        };

        return _uloga;
    }

    public static List<Prioritet> ReturnPrioritet()
    {
        List<Prioritet> _prioritet = new List<Prioritet>(){
            new Prioritet() { PrioritetId=1, Ime="Mora biti"},
            new Prioritet() { PrioritetId=2, Ime="Može biti"},
            new Prioritet() { PrioritetId=3, Ime="Neće biti"},
            new Prioritet() { PrioritetId=4, Ime="Treba biti"},
        };

        return _prioritet;
    }

    public static List<VrstaProjekta> ReturnVrstaProjekta()
    {
        List<VrstaProjekta> _vrsteProjekta = new List<VrstaProjekta>(){
            new VrstaProjekta() { VrstaProjektaId=1, Ime="Poslovni"},
            new VrstaProjekta() { VrstaProjektaId=2, Ime="Znanstveni"},
            new VrstaProjekta() { VrstaProjektaId=3, Ime="Nastavni"},
            new VrstaProjekta() { VrstaProjektaId=4, Ime="Istraživačko-razvojni"},
        };

        return _vrsteProjekta;
    }

    public static List<TipZahtjeva> ReturnTipZahtjeva()
    {
        List<TipZahtjeva> _tipZahtjeva = new List<TipZahtjeva>(){
            new TipZahtjeva() { TipZahtjevaId=1, Ime="Poslovni"},
            new TipZahtjeva() { TipZahtjevaId=2, Ime="Sistemski"},
            new TipZahtjeva() { TipZahtjevaId=3, Ime="Korisnički"},
            new TipZahtjeva() { TipZahtjevaId=4, Ime="Funkcionalni"},
            new TipZahtjeva() { TipZahtjevaId=5, Ime="Nefunkcionalni"},
            new TipZahtjeva() { TipZahtjevaId=6, Ime="Sigurnosni"},
            new TipZahtjeva() { TipZahtjevaId=7, Ime="Kulturološki"},
        };

        return _tipZahtjeva;
    }

    public static List<Aktivnost> ReturnAktivnost()
    {
        List<Aktivnost> _aktivnost = new List<Aktivnost>(){
            new Aktivnost() { AktivnostId=1, Ime="Sistem analiza"},
            new Aktivnost() { AktivnostId=2, Ime="Testiranje"},
            new Aktivnost() { AktivnostId=3, Ime="Razvoj"},
            new Aktivnost() { AktivnostId=4, Ime="Isporuka"},
        };

        return _aktivnost;
    }

    public static List<Status> ReturnStatus()
    {
        List<Status> _status = new List<Status>(){
            new Status() { StatusId=1, Ime="U toku", ZastavicaAktivnosti="Aktivan"},
            new Status() { StatusId=2, Ime="Nezapočet", ZastavicaAktivnosti="Neaktivan"},
            new Status() { StatusId=3, Ime="Odbačen", ZastavicaAktivnosti="Neaktivan"},
            new Status() { StatusId=4, Ime="Dovršen", ZastavicaAktivnosti="Aktivan"},
            new Status() { StatusId=5, Ime="Odgođen", ZastavicaAktivnosti="Aktivan"},
        };

        return _status;
    }

}
