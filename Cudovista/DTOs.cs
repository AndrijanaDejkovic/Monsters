using Cudovista.Entiteti;
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
        public class NemagijskaCudovistaPregled
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
       


        public NemagijskaCudovistaPregled()
            {

            }
            public NemagijskaCudovistaPregled(int id_Nemagijskog, int starost, int da_li_zivi_u_vodi, int da_li_leti, int da_li_ima_rep, int da_li_je_otrovno, int da_li_ima_kandze, int broj_ociju, int broj_glava, int broj_ekstremiteta, int tezina, int duzina)
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

        public class NemagijskaCudovistaBasic
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


            public NemagijskaCudovistaBasic()
            {

            }
            public NemagijskaCudovistaBasic(int id_Nemagijskog, int starost, int da_li_zivi_u_vodi, int da_li_leti, int da_li_ima_rep, int da_li_je_otrovno, int da_li_ima_kandze, int broj_ociju, int broj_glava, int broj_ekstremiteta, int tezina, int duzina)
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
            public LobanjaBasic(int id, Cudoviste c, Materijal m, string tip_predmeta) : base(id,c, m, tip_predmeta)
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
            public  Materijal ID_Materijala { get; set; }
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
            this.ID = id ;
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
            this.Id_cudovista =id_cudovista;

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

}
