using Cudovista.Entiteti;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Cudovista
{
    public class PredstavnikPregled
    {
        public int IDPredstavnika;
        public string Ime_predstavnika;
        public int Starost;
        public DateTime DatumSusreta;
        public string Ishod;
        public Cudoviste Id_cudovista;
        public Lokacija Id_lokacije;



        public PredstavnikPregled()
        {

        }
        public PredstavnikPregled(int idPredstavnika, int starost, string ime_predstavnika, DateTime datumSusreta, string ishod, Cudoviste c, Lokacija l)
        {
            this.IDPredstavnika = idPredstavnika;
            this.Ime_predstavnika = ime_predstavnika;
            this.Starost = starost;
            this.DatumSusreta = datumSusreta;
            this.Ishod = ishod;
            this.Id_cudovista = c;
            this.Id_lokacije = l;

        }
    }

    public class PredstavnikBasic
    {
        public int IDPredstavnika;
        public string Ime_predstavnika;
        public int Starost;
        public DateTime DatumSusreta;
        public string Ishod;
        public Cudoviste Id_cudovista;
        public Lokacija Id_lokacije;

        public IList<Lovac> Love_ga;


        public PredstavnikBasic()
        {
            Love_ga = new List<Lovac>();
        }
        public PredstavnikBasic(int idPredstavnika, int starost, string ime_predstavnika, DateTime datumSusreta, string ishod, Cudoviste c, Lokacija l)
        {
            this.IDPredstavnika = idPredstavnika;
            this.Ime_predstavnika = ime_predstavnika;
            this.Starost = starost;
            this.DatumSusreta = datumSusreta;
            this.Ishod = ishod;
            this.Id_cudovista = c;
            this.Id_lokacije = l;

        }
    }
    public class NemagijskoCudovistePregled : CudivistePregled
    {
        //nisam menjala konstruktore
        public int ID_Nemagijskog;
        public int Da_li_zivi_u_vodi;
        public int Da_li_leti;
        public int Da_li_ima_rep;
        public int Da_li_je_otrovno;
        public int Da_li_ima_kandze;
        public int Broj_ociju;
        public int Broj_glava;
        public int Broj_ekstremiteta;
        public int Duzina;
        public int Tezina;



        public NemagijskoCudovistePregled()
        {

        }
        public NemagijskoCudovistePregled(int id_Nemagijskog, int da_li_zivi_u_vodi, int da_li_leti, int da_li_ima_rep, int da_li_je_otrovno, int da_li_ima_kandze, int broj_ociju, int broj_glava, int broj_ekstremiteta, int tezina, int duzina)
        {
            this.ID_Nemagijskog = id_Nemagijskog;
            this.Da_li_zivi_u_vodi = da_li_zivi_u_vodi;
            this.Da_li_leti = da_li_leti;
            this.Da_li_ima_rep = da_li_ima_rep;
            this.Da_li_je_otrovno = da_li_je_otrovno;
            this.Da_li_ima_kandze = da_li_ima_kandze;
            this.Broj_ociju = broj_ociju;
            this.Broj_glava = broj_glava;
            this.Broj_ekstremiteta = broj_ekstremiteta;
            this.Duzina = duzina;
            this.Tezina = tezina;
        }
    }

    public class NemagijskoCudovisteBasic : CudivisteBasic
    {
        public int ID_Nemagijskog;
        public int Da_li_zivi_u_vodi;
        public int Da_li_leti;
        public int Da_li_ima_rep;
        public int Da_li_je_otrovno;
        public int Da_li_ima_kandze;
        public int Broj_ociju;
        public int Broj_glava;
        public int Broj_ekstremiteta;
        public int Duzina;
        public int Tezina;


        public NemagijskoCudovisteBasic()
        {

        }
        public NemagijskoCudovisteBasic(int ID, string Naziv, int Vek, string Podtip, int id_Nemagijskog, int da_li_zivi_u_vodi, int da_li_leti, int da_li_ima_rep, int da_li_je_otrovno, int da_li_ima_kandze, int broj_ociju, int broj_glava, int broj_ekstremiteta, int tezina, int duzina)
        {
            this.ID = ID;
            this.ID_Nemagijskog = id_Nemagijskog;
            this.Da_li_zivi_u_vodi = da_li_zivi_u_vodi;
            this.Da_li_leti = da_li_leti;
            this.Da_li_ima_rep = da_li_ima_rep;
            this.Da_li_je_otrovno = da_li_je_otrovno;
            this.Da_li_ima_kandze = da_li_ima_kandze;
            this.Broj_ociju = broj_ociju;
            this.Broj_glava = broj_glava;
            this.Broj_ekstremiteta = broj_ekstremiteta;
            this.Duzina = duzina;
            this.Tezina = tezina;
            this.Vek = Vek;
            this.Podtip = Podtip;
            this.Naziv_cudovista = Naziv;
        }
        

    }

    public class PredmetBasic
    {
        public int ID { get; set; }
        public Cudoviste Id_cudovista { get; set; }
        public Materijal ID_Materijala { get; set; }
        public string Tip_Predmeta { get; set; }

        public PredmetBasic(int id, Cudoviste c, Materijal m, string tip_predmeta)
        {

        }
        public PredmetBasic()
        {

        }
    }
    public class LobanjaBasic : PredmetBasic
    {
        public LobanjaBasic()
        {

        }
        public LobanjaBasic(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id, c, m, tip_predmeta)
        {
        }
    }

    public class KrstBasic : PredmetBasic
    {
        public KrstBasic()
        {

        }
        public KrstBasic(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id, c, m, tip_predmeta)
        {
        }
    }

    public class MacBasic : PredmetBasic
    {
        public MacBasic()
        {

        }
        public MacBasic(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id, c, m, tip_predmeta)
        {
        }
    }

    public class KnjigaBasic : PredmetBasic
    {
        public KnjigaBasic()
        {

        }
        public KnjigaBasic(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id, c, m, tip_predmeta)
        {
        }
    }


    public class PredmetPregled
    {
        public int ID { get; set; }
        public Cudoviste Id_cudovista { get; set; }
        public Materijal ID_Materijala { get; set; }
        public string Tip_Predmeta { get; set; }


        public PredmetPregled(int id, Cudoviste c, Materijal m, string tip_predmeta)
        {
            this.ID = id;
            this.Id_cudovista = c;
            this.ID_Materijala = m;
            this.Tip_Predmeta = tip_predmeta;
        }

        public PredmetPregled()
        {
        }

    }
    public class KrstPregled : PredmetPregled
    {

        public KrstPregled(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id, c, m, tip_predmeta)
        {
        }
    }

    public class LobanjaPregled : PredmetPregled
    {
        public LobanjaPregled(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id, c, m, tip_predmeta)
        {
        }
    }

    public class MacPregled : PredmetPregled
    {
        public MacPregled(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id, c, m, tip_predmeta)
        {
        }
    }
    public class KnjigaPregled : PredmetPregled
    {
        public KnjigaPregled(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id, c, m, tip_predmeta)
        {
        }
    }

    public class CudivistePregled
    {
        public int ID;
        public int Vek;
        public string Naziv_cudovista;
        public string Podtip;

        public CudivistePregled()
        {

        }
        public CudivistePregled(int id, string podtip, string naziv_cudovista, int vek)
        {
            this.ID = id;
            this.Naziv_cudovista = naziv_cudovista;
            this.Podtip = podtip;
            this.Vek = vek;

        }
    }

    public class CudivisteBasic
    {
        public int ID;
        public int Vek;
        public string Naziv_cudovista;
        public string Podtip;
        public IList<Protivmere> Protivmere;
        public IList<Predmet> Predmeti;
        public IList<Predstavnik> Predstavnici;
        public IList<Legende> Legende;
        public IList<Bajalice> Bajalice;
        public CudivisteBasic()
        {
            Predstavnici = new List<Predstavnik>();
            Legende = new List<Legende>();
            Predmeti = new List<Predmet>();
            Bajalice = new List<Bajalice>();
            Protivmere = new List<Protivmere>();
            Predmeti = new List<Predmet>();
        }
        public CudivisteBasic(int id, string podtip, string naziv_cudovista, int vek)
        {
            this.ID = id;
            this.Naziv_cudovista = naziv_cudovista;
            this.Podtip = podtip;
            this.Vek = vek;

        }
    }


    public class LegendePregled
    {
        public int ID;
        public string Tekst;
        public DateTime Prvo_pominjanje;
        public string Zemlja_porekla;
        public Cudoviste Id_cudovista;

        public LegendePregled()
        {

        }
        public LegendePregled(int id, string tekst, DateTime prvo_pominjanje, string Zemlja_porekla, Cudoviste id_cudovista)
        {
            this.ID = id;
            this.Tekst = tekst;
            this.Prvo_pominjanje = prvo_pominjanje;
            this.Zemlja_porekla = Zemlja_porekla;
            this.Id_cudovista = id_cudovista;

        }
    }

    public class LegendeBasic
    {
        public int ID;
        public string Tekst;
        public DateTime Prvo_pominjanje;
        public string Zemlja_porekla;
        public Cudoviste Id_cudovista;


        public LegendeBasic()
        {

        }
        public LegendeBasic(int id, string tekst, DateTime prvo_pominjanje, string Zemlja_porekla, Cudoviste id_cudovista)
        {
            this.ID = id;
            this.Tekst = tekst;
            this.Prvo_pominjanje = prvo_pominjanje;
            this.Zemlja_porekla = Zemlja_porekla;
            this.Id_cudovista = id_cudovista;
        }
    }
    public class MagijskoCudovistePregled : CudivistePregled
    {
        //okej je sa otkomentarisanom argumentima
        public int Da_li_postoji;

        public MagijskoCudovistePregled()
        {

        }
        public MagijskoCudovistePregled(int id, string podtip, string naziv_cudovista, int vek, int da_li_postoji)
        {
            this.ID = id;
            this.Naziv_cudovista = naziv_cudovista;
            this.Podtip = podtip;
            this.Vek = vek;
            
            this.Da_li_postoji = da_li_postoji;

        }
    }

    public class MagijskoCudovisteBasic : CudivisteBasic
    {
        public int Da_li_postoji;
        public IList<Magijske_sposobnosti> Poseduje_sposobnosti;
        public  IList<Protivmere> mProtivmere { get; set; }
        public  IList<Predmet> mPredmeti { get; set; }
        public  IList<Predstavnik> mPredstavnici { get; set; }
        public  IList<Legende> mLegende { get; set; }
        public  IList<Bajalice> mBajalice { get; set; }
        public MagijskoCudovisteBasic()
        {
            Poseduje_sposobnosti = new List<Magijske_sposobnosti>();
            mPredmeti = new List<Predmet>();
            mPredstavnici  = new List<Predstavnik>();
            mProtivmere = new List<Protivmere>();
            mLegende = new List<Legende>();
        }
        public MagijskoCudovisteBasic(int id, string podtip, string naziv_cudovista, int vek, int da_li_postoji)
        {
            this.ID = id;
            this.Naziv_cudovista = naziv_cudovista;
            this.Podtip = podtip;
            this.Vek = vek;
           
            this.Da_li_postoji = da_li_postoji;

        }
    }

    public class MaterijalBasic
    {
        public int ID { get; set; }

        public string Tip_Materijala { get; set; }

        public Predmet Pripada_predmetu { get; set; }

        public MaterijalBasic(int ID, Predmet Pripada_predmetu, string Tip_Materijala)
        {
            this.ID = ID;
            this.Pripada_predmetu = Pripada_predmetu;
            this.Tip_Materijala = Tip_Materijala;

        }
        public MaterijalBasic()
        {

        }
    }
    public class ZlatoBasic : MaterijalBasic
    {
        public ZlatoBasic()
        {

        }
        public ZlatoBasic(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
        {
        }
    }

    public class SrebroBasic : MaterijalBasic
    {
        public SrebroBasic()
        {

        }
        public SrebroBasic(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
        {
        }
    }

    public class DijamantBasic : MaterijalBasic
    {
        public DijamantBasic()
        {

        }
        public DijamantBasic(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
        {
            {
            }
        }

        public class PapirBasic : MaterijalBasic
        {
            public PapirBasic()
            {

            }
            public PapirBasic(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
            {
                {
                }
            }
        }

        public class MetalBasic : MaterijalBasic
        {
            public MetalBasic()
            {

            }
            public MetalBasic(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
            {
                {
                }
            }
        }


        public class MaterijalPregled
        {
            public int ID { get; set; }

            public string Tip_Materijala { get; set; }

            public Predmet Pripada_predmetu { get; set; }


            public MaterijalPregled(int ID, Predmet Pripada_predmetu, string Tip_Materijala)
            {
                this.ID = ID;
                this.Pripada_predmetu = Pripada_predmetu;
                this.Tip_Materijala = Tip_Materijala;
            }

            public MaterijalPregled()
            {
            }

        }
        public class ZlatoPregled : MaterijalPregled
        {

            public ZlatoPregled(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
            {
            }


        }

        public class SrebroPregled : MaterijalPregled
        {
            public SrebroPregled(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
            {
            }

        }

        public class DijamantPregled : MaterijalPregled
        {
            public DijamantPregled(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
            {
            }


        }
        public class PapirPregled : MaterijalPregled
        {
            public PapirPregled(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
            {
            }

        }

        public class MetalPregled : MaterijalPregled
        {
            public MetalPregled(int ID, Predmet Pripada_predmetu, string Tip_Materijala) : base(ID, Pripada_predmetu, Tip_Materijala)
            {
            }

        }
    }

    public class MagijskeSposobnostiPregled
    {
        public int ID;
        public string Naziv_sposobnosti;
        public int Da_li_je_odbrambena;
        public string Opis_sposobnosti;
        public Magijsko_cudoviste Id_cudovista;

        public MagijskeSposobnostiPregled()
        {

        }
        public MagijskeSposobnostiPregled(int ID, string Naziv_sposobnosti, int Da_li_je_odbrambena, string Opis_sposobnosti, Magijsko_cudoviste id_cudovista)
        {
            this.ID = ID;
            this.Naziv_sposobnosti = Naziv_sposobnosti;
            this.Da_li_je_odbrambena = Da_li_je_odbrambena;
            this.Opis_sposobnosti = Opis_sposobnosti;
            this.Id_cudovista = id_cudovista;

        }
    }

    public class MagijskeSposobnostiBasic
    {
        public int ID;
        public string Naziv_sposobnosti;
        public int Da_li_je_odbrambena;
        public string Opis_sposobnosti;
        public Magijsko_cudoviste Id_cudovista;



        public MagijskeSposobnostiBasic()
        {

        }
        public MagijskeSposobnostiBasic(int ID, string Naziv_sposobnosti, int Da_li_je_odbrambena, string Opis_sposobnosti, Magijsko_cudoviste id_cudovista)
        {
            this.ID = ID;
            this.Naziv_sposobnosti = Naziv_sposobnosti;
            this.Da_li_je_odbrambena = Da_li_je_odbrambena;
            this.Opis_sposobnosti = Opis_sposobnosti;
            this.Id_cudovista = id_cudovista;
        }

    }

    public class ProtivmerePregled
    {
        public int ID;
        public string Naziv_protivmere;
        public string Opis_protivmere;
        public int Da_li_uslovi;
        public Cudoviste Id_cudovista;

        public ProtivmerePregled()
        {

        }
        public ProtivmerePregled(int ID, string Naziv_protivmere, int Da_li_uslovi, string Opis_protivmere, Cudoviste Id_cudovista)
        {
            this.ID = ID;
            this.Naziv_protivmere = Naziv_protivmere;
            this.Opis_protivmere = Opis_protivmere;
            this.Da_li_uslovi = Da_li_uslovi;
            this.Id_cudovista = Id_cudovista;

        }
    }

    public class ProtivmereBasic
    {
        public int ID;
        public string Naziv_protivmere;
        public string Opis_protivmere;
        public int Da_li_uslovi;
        public Cudoviste Id_cudovista;

        public ProtivmereBasic()
        {

        }
        public ProtivmereBasic(int ID, string Naziv_protivmere, int Da_li_uslovi, string Opis_protivmere, Cudoviste Id_cudovista)
        {

            this.ID = ID;
            this.Naziv_protivmere = Naziv_protivmere;
            this.Opis_protivmere = Opis_protivmere;
            this.Da_li_uslovi = Da_li_uslovi;
            this.Id_cudovista = Id_cudovista;
        }

    }

    public class BajalicePregled
    {
        public int ID;
        public string Bajalica;
        public Cudoviste Id_cudovista;

        public BajalicePregled()
        {

        }
        public BajalicePregled(int ID, string Bajalica, Cudoviste Id_cudovista)
        {
            this.ID = ID;
            this.Bajalica = Bajalica;
            this.Id_cudovista = Id_cudovista;

        }
    }

    public class BajaliceBasic
    {
        public int ID;
        public string Bajalica;
        public Cudoviste Id_cudovista;


        public BajaliceBasic()
        {

        }
        public BajaliceBasic(int ID, string Bajalica, Cudoviste Id_cudovista)
        {

            this.ID = ID;
            this.Bajalica = Bajalica;
            this.Id_cudovista = Id_cudovista;
        }

    }

    public class SpecijalneSposobnostiPregled
    {
        public int ID;
        public string Spec_sposobnosti;
        public Cudoviste Id_cudovista;

        public SpecijalneSposobnostiPregled()
        {

        }
        public SpecijalneSposobnostiPregled(int ID, string Spec_sposobnosti, Cudoviste Id_cudovista)
        {
            this.ID = ID;
            this.Spec_sposobnosti = Spec_sposobnosti;
            this.Id_cudovista = Id_cudovista;

        }
    }

    public class SpecijalneSposobnostiBasic
    {
        public int ID;
        public string Spec_sposobnosti;
        public Cudoviste Id_cudovista;


        public SpecijalneSposobnostiBasic()
        {

        }
        public SpecijalneSposobnostiBasic(int ID, string Spec_sposobnosti, Cudoviste Id_cudovista)
        {

            this.ID = ID;
            this.Spec_sposobnosti = Spec_sposobnosti;
            this.Id_cudovista = Id_cudovista;
        }

    }

    public class LokacijaBasic
    {
        public int ID;
        public string Naziv_lokacije;
        public string Tip_lokacije;
        public string Zemlja;
        public string Blago;
        public Predstavnik Borio_se;

        public LokacijaBasic(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se)
        {
            this.ID = ID;
            this.Naziv_lokacije = Naziv_lokacije;
            this.Tip_lokacije = Tip_lokacije;
            this.Zemlja = Zemlja;
            this.Blago = Blago;
            this.Borio_se = Borio_se;


        }
        public LokacijaBasic()
        {

        }
    }
    public class OstrvoBasic : LokacijaBasic
    {
        public OstrvoBasic()
        {

        }
        public OstrvoBasic(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)
        {
        }
    }

    public class PiramidaBasic : LokacijaBasic
    {
        public PiramidaBasic()
        {

        }
        public PiramidaBasic(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)
        {
            {
            }
        }

        public class GradDuhovaBasic : LokacijaBasic
        {
            public GradDuhovaBasic()
            {

            }
            public GradDuhovaBasic(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)

            {
                {
                }
            }

            public class UkletiZamakBasic : LokacijaBasic
            {
                public UkletiZamakBasic()
                {

                }
                public UkletiZamakBasic(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)

                {
                    {
                    }
                }
            }

            public class PecinaBasic : LokacijaBasic
            {
                public PecinaBasic()
                {

                }
                public PecinaBasic(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)
                {
                    {
                        {
                        }
                    }
                }


                public class LokacijaPregled
                {
                    public int ID;
                    public string Naziv_lokacije;
                    public string Tip_lokacije;
                    public string Zemlja;
                    public string Blago;
                    public Predstavnik Borio_se;

                    public IList<Zastita> Zastite;
                    public IList<Zivi_na> ZivePredstavnici;


                    public LokacijaPregled()
                    {
                        Zastite = new List<Zastita>();
                        ZivePredstavnici = new List<Zivi_na>();

                    }

                    public LokacijaPregled(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se)
                    {
                        this.ID = ID;
                        this.Naziv_lokacije = Naziv_lokacije;
                        this.Tip_lokacije = Tip_lokacije;
                        this.Zemlja = Zemlja;
                        this.Blago = Blago;
                        this.Borio_se = Borio_se;
                    }

                }
                public class GradDuhovaPregled : LokacijaPregled
                {

                    public GradDuhovaPregled(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)

                    {
                    }


                }

                public class OstrvoPregled : LokacijaPregled
                {
                    public OstrvoPregled(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)

                    {
                    }

                }

                public class PiramidaPregled : LokacijaPregled
                {
                    public PiramidaPregled(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)

                    {
                    }


                }
                public class UkletiZamakPregled : LokacijaPregled
                {
                    public UkletiZamakPregled(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)

                    {
                    }

                }

                public class PecinaPregled : LokacijaPregled
                {
                    public PecinaPregled(int ID, string Naziv_lokacije, string Tip_lokacije, string Zemlja, string Blago, Predstavnik Borio_se) : base(ID, Naziv_lokacije, Tip_lokacije, Zemlja, Blago, Borio_se)

                    {
                    }

                }
            }
        }
    }


    public class ZastitaBasic
    {
        public int ID;
        public string Naziv_zastite;

        public string Tip_zastite;
        public Lokacija Id_lokacije;

        public ZastitaBasic()
        {
            


        }
        public ZastitaBasic(int ID, string Naziv_zastite, string Tip_zastite, Lokacija Id_lokacije)
        {
            this.ID = ID;
            this.Naziv_zastite = Naziv_zastite;
            this.Tip_zastite = Tip_zastite;
            this.Id_lokacije = Id_lokacije;
        }
    }
    public class DuhBasic : ZastitaBasic
    {
        public DuhBasic()
        {

        }
        public DuhBasic(int ID, string Naziv_zastite, string Tip_zastite, Lokacija Id_lokacije) : base(ID, Naziv_zastite, Tip_zastite, Id_lokacije)
        {
        }
    }

    public class ZmajBasic : ZastitaBasic
    {
        public ZmajBasic()
        {

        }
        public ZmajBasic(int ID, string Naziv_zastite, string Tip_zastite, Lokacija Id_lokacije) : base(ID, Naziv_zastite, Tip_zastite, Id_lokacije)
        {
            {
            }
        }
    }
    public class KletvaBasic : ZastitaBasic
    {
        public KletvaBasic()
        {

        }
        public KletvaBasic(int ID, string Naziv_zastite, string Tip_zastite, Lokacija Id_lokacije) : base(ID, Naziv_zastite, Tip_zastite, Id_lokacije)

        {
            {
            }
        }

    }
    public class ZastitaPregled
    {
        public int ID;
        public string Naziv_zastite;

        public string Tip_zastite;
        public Lokacija Id_lokacije;


        public ZastitaPregled()
        {


        }

        public ZastitaPregled(int ID, string Naziv_zastite, string Tip_zastite, Lokacija Id_lokacije)
        {
            this.ID = ID;
            this.Naziv_zastite = Naziv_zastite;
            this.Tip_zastite = Tip_zastite;
            this.Id_lokacije = Id_lokacije;


        }
    }
    public class KletvaPregled : ZastitaPregled
    {

        public KletvaPregled(int ID, string Naziv_zastite, string Tip_zastite, Lokacija Id_lokacije) : base(ID, Naziv_zastite, Tip_zastite, Id_lokacije)

        {
        }


    }

    public class DuhPregled : ZastitaPregled
    {
        public DuhPregled(int ID, string Naziv_zastite, string Tip_zastite, Lokacija Id_lokacije) : base(ID, Naziv_zastite, Tip_zastite, Id_lokacije)

        {
        }

    }

    public class ZmajPregled : ZastitaPregled
    {
        public ZmajPregled(int ID, string Naziv_zastite, string Tip_zastite, Lokacija Id_lokacije) : base(ID, Naziv_zastite, Tip_zastite, Id_lokacije)

        {
        }


    }
  

    public class ZiviNaPregled
    {
        public int ID;
        //public int Id_lokacije;
        //public int Id_predstavnika;
        public Predstavnik predstavnikZivi;
        public Lokacija lokacijaZivota;

        public ZiviNaPregled()
        {

        }
        public ZiviNaPregled(int ID, /* int Id_lokacije, int Id_predstavnika,*/  Predstavnik predstavnikZivi, Lokacija lokacijaZivota)
        {
            this.ID = ID;
            this.predstavnikZivi = predstavnikZivi;
            this.lokacijaZivota = lokacijaZivota;

        }
    }

    public class ZiviNaBasic
    {
        public int ID;
        //public int Id_lokacije;
        //public int Id_predstavnika;
        public Predstavnik predstavnikZivi;
        public Lokacija lokacijaZivota;


        public ZiviNaBasic()
        {

        }
        public ZiviNaBasic(int ID, /* int Id_lokacije, int Id_predstavnika,*/  Predstavnik predstavnikZivi, Lokacija lokacijaZivota)
        {
            this.ID = ID;
            this.predstavnikZivi = predstavnikZivi;
            this.lokacijaZivota = lokacijaZivota;
        }

    }
}







