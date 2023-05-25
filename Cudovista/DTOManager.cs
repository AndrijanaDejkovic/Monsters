using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using NHibernate;
using Cudovista.Entiteti;
using static System.Net.Mime.MediaTypeNames;
using static Cudovista.Entiteti.Lokacija;
using static Cudovista.DijamantBasic;
using NHibernate.Mapping;
using static Cudovista.PiramidaBasic.GradDuhovaBasic.PecinaBasic;
using static Cudovista.PiramidaBasic;
using static Cudovista.PiramidaBasic.GradDuhovaBasic;
using static Cudovista.ZmajBasic;
using static Cudovista.KletvaBasic;

namespace Cudovista
{
    internal class DTOManager
    {
        #region Cudoviste
        public static List<CudivistePregled> vratiSvaCudovista()
        {
            List<CudivistePregled> cudovista = new List<CudivistePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Cudoviste> svaCudovista = from o in s.Query<Cudovista.Entiteti.Cudoviste>()
                                                                         select o;

                foreach (Cudovista.Entiteti.Cudoviste p in svaCudovista)
                {
                    cudovista.Add(new CudivistePregled(p.ID, p.Podtip, p.Naziv_cudovista, p.Vek));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return cudovista;
        }

        public static void dodajCudoviste(CudivisteBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Cudoviste o = new Cudovista.Entiteti.Cudoviste();

                o.ID = p.ID;
                o.Naziv_cudovista = p.Naziv_cudovista;
                o.Podtip = p.Podtip;
                o.Vek = p.Vek;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static CudivisteBasic azurirajCudoviste(CudivisteBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Cudoviste o = s.Load<Cudovista.Entiteti.Cudoviste>(p.ID);
                o.ID = p.ID;
                o.Naziv_cudovista = p.Naziv_cudovista;
                o.Podtip = p.Podtip;
                o.Vek = p.Vek;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static CudivisteBasic vratiCudoviste(int id)
        {
            CudivisteBasic pb = new CudivisteBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Cudoviste p = s.Load<Cudovista.Entiteti.Cudoviste>(id);
                pb = new CudivisteBasic(p.ID, p.Podtip, p.Naziv_cudovista, p.Vek);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiCudoviste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Cudoviste o = s.Load<Cudovista.Entiteti.Cudoviste>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Cudoviste

        #region Predstavnik
        public static List<PredstavnikPregled> vratiSvePredstavnike()
        {
            List<PredstavnikPregled> predstavnici = new List<PredstavnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Predstavnik> sviPredstavnici = from o in s.Query<Cudovista.Entiteti.Predstavnik>()
                                                                              select o;

                foreach (Cudovista.Entiteti.Predstavnik p in sviPredstavnici)
                {
                    predstavnici.Add(new PredstavnikPregled(p.ID, p.Starost, p.Ime_predstavnika, p.Datum_susreta, p.Ishod, p.Id_cudovista, p.Id_lokacije));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return predstavnici;
        }

        public static void dodajPredstavnika(PredstavnikBasic o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Predstavnik p = new Cudovista.Entiteti.Predstavnik();

                p.ID = o.IDPredstavnika;
                p.Ime_predstavnika = o.Ime_predstavnika;
                p.Starost = o.Starost;
                p.Datum_susreta = o.DatumSusreta;
                p.Ishod = o.Ishod;
                p.Id_cudovista = o.Id_cudovista;
                p.Id_lokacije = o.Id_lokacije;
                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static PredstavnikBasic azurirajPredstavnika(PredstavnikBasic o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Predstavnik p = s.Load<Cudovista.Entiteti.Predstavnik>(o.IDPredstavnika);
                p.ID = o.IDPredstavnika;
                p.Ime_predstavnika = o.Ime_predstavnika;
                p.Starost = o.Starost;
                p.Datum_susreta = o.DatumSusreta;
                p.Ishod = o.Ishod;
                p.Id_cudovista = o.Id_cudovista;
                p.Id_lokacije = o.Id_lokacije;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;
        }

        public static PredstavnikBasic vratiPredstavnika(int id)
        {
            PredstavnikBasic pb = new PredstavnikBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Predstavnik p = s.Load<Cudovista.Entiteti.Predstavnik>(id);
                pb = new PredstavnikBasic(p.ID, p.Starost, p.Ime_predstavnika, p.Datum_susreta, p.Ishod, p.Id_cudovista, p.Id_lokacije);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiPredstavnika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Predstavnik o = s.Load<Cudovista.Entiteti.Predstavnik>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Predstavnik

        #region Predmet


        #region Krst
        public static void obrisiPredmet(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Krst predmet = s.Load<Krst>(id);

                s.Delete(predmet);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static KrstBasic vratiKrstBasic(int id)
        {
            KrstBasic o = new KrstBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Krst predmet = s.Load<Krst>(id);

                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;




                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }
        public static List<PredmetPregled> vratiPredmeteJednogOdeljenja(int CudovisteId)
        {
            List<PredmetPregled> odInfos = new List<PredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predmet> predmeti = from o in s.Query<Predmet>()
                                                where o.Id_cudovista.ID == CudovisteId
                                                select o;

                foreach (Predmet o in predmeti)
                {
                    odInfos.Add(new PredmetPregled(o.ID, o.Id_cudovista, o.ID_Materijala, o.Tip_Predmeta));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static List<KrstPregled> vratiKrst(int CudovisteId)
        {
            List<KrstPregled> odInfos = new List<KrstPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Krst> predmeti = from o in s.Query<Krst>()
                                             where o.Id_cudovista.ID == CudovisteId
                                             select o;

                foreach (Krst o in predmeti)
                {
                    odInfos.Add(new KrstPregled(o.ID, o.Id_cudovista, o.ID_Materijala, o.Tip_Predmeta));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniKrst(KrstBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Krst o = s.Load<Krst>(predmet.ID);


                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajKrst(KrstBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Krst o = new Cudovista.Entiteti.Krst();


                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;

                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Krst

        #region Lobanja 

        public static KrstBasic vratiLobanjuBasic(int id)
        {
            KrstBasic o = new KrstBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Lobanja predmet = s.Load<Lobanja>(id);

                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;




                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static List<LobanjaPregled> vratiLobanju(int CudovisteId)
        {
            List<LobanjaPregled> odInfos = new List<LobanjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lobanja> predmeti = from o in s.Query<Lobanja>()
                                                where o.Id_cudovista.ID == CudovisteId
                                                select o;

                foreach (Lobanja o in predmeti)
                {
                    odInfos.Add(new LobanjaPregled(o.ID, o.Id_cudovista, o.ID_Materijala, o.Tip_Predmeta));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniLobanju(LobanjaBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lobanja o = s.Load<Lobanja>(predmet.ID);


                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajLobanju(LobanjaBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lobanja o = new Cudovista.Entiteti.Lobanja();


                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;

                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion Lobanja
        #region Mac
        public static List<MacPregled> vratiMac(int CudovisteId)
        {
            List<MacPregled> odInfos = new List<MacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Mac> predmeti = from o in s.Query<Mac>()
                                            where o.Id_cudovista.ID == CudovisteId
                                            select o;

                foreach (Mac o in predmeti)
                {
                    odInfos.Add(new MacPregled(o.ID, o.Id_cudovista, o.ID_Materijala, o.Tip_Predmeta));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniMac(MacBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Mac o = s.Load<Mac>(predmet.ID);


                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajMac(MacBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Mac o = new Cudovista.Entiteti.Mac();


                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;

                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Mac

        #region Knjiga
        public static List<KnjigaPregled> vratiKnjiga(int CudovisteId)
        {
            List<KnjigaPregled> odInfos = new List<KnjigaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Knjiga> predmeti = from o in s.Query<Knjiga>()
                                               where o.Id_cudovista.ID == CudovisteId
                                               select o;

                foreach (Knjiga o in predmeti)
                {
                    odInfos.Add(new KnjigaPregled(o.ID, o.Id_cudovista, o.ID_Materijala, o.Tip_Predmeta));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniKnjiga(KnjigaBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Knjiga o = s.Load<Knjiga>(predmet.ID);


                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajKnjigu(KnjigaBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Knjiga o = new Cudovista.Entiteti.Knjiga();


                o.ID = predmet.ID;
                o.Id_cudovista = predmet.Id_cudovista;
                o.ID_Materijala = predmet.ID_Materijala;
                o.Tip_Predmeta = predmet.Tip_Predmeta;

                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Knjiga

        #endregion Predmet

        #region Legende
        public static List<LegendePregled> vratiSvaLegende()
        {
            List<LegendePregled> cudovista = new List<LegendePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Legende> sveLegende = from o in s.Query<Cudovista.Entiteti.Legende>()
                                                                     select o;

                foreach (Cudovista.Entiteti.Legende p in sveLegende)
                {
                    cudovista.Add(new LegendePregled(p.ID, p.Tekst, p.Prvo_pominjanje, p.Zemlja_porekla, p.Id_cudovista));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return cudovista;
        }

        public static void dodajLegendu(LegendeBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Legende o = new Cudovista.Entiteti.Legende();

                o.ID = p.ID;
                o.Tekst = p.Tekst;
                o.Prvo_pominjanje = p.Prvo_pominjanje;
                o.Zemlja_porekla = p.Zemlja_porekla;
                o.Id_cudovista = p.Id_cudovista;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static LegendeBasic azurirajLegendu(LegendeBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Legende o = s.Load<Cudovista.Entiteti.Legende>(p.ID);
                o.ID = p.ID;
                o.Tekst = p.Tekst;
                o.Prvo_pominjanje = p.Prvo_pominjanje;
                o.Zemlja_porekla = p.Zemlja_porekla;
                o.Id_cudovista = p.Id_cudovista;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static LegendeBasic vratiLegendu(int id)
        {
            LegendeBasic pb = new LegendeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Legende p = s.Load<Cudovista.Entiteti.Legende>(id);
                pb = new LegendeBasic(p.ID, p.Tekst, p.Prvo_pominjanje, p.Zemlja_porekla, p.Id_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiLegendu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Legende o = s.Load<Cudovista.Entiteti.Legende>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Legende

        #region MagijskaCudovista
        
        public static List<MagijskoCudovistePregled> vratiSvaMagijskaCudovista()
        {
            
            List<MagijskoCudovistePregled> cudovista = new List<MagijskoCudovistePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Magijsko_cudoviste> svaMagijska = from o in s.Query<Cudovista.Entiteti.Magijsko_cudoviste>()
                                                                     select o;

                foreach (Cudovista.Entiteti.Magijsko_cudoviste o in svaMagijska)
                {
                    cudovista.Add(new MagijskoCudovistePregled(o.ID, o.Podtip, o.Naziv_cudovista, o.Vek, o.Da_li_postoji));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return cudovista;
        }
        

        public static void dodajMagijskoCudoviste(MagijskoCudovisteBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Magijsko_cudoviste o = new Cudovista.Entiteti.Magijsko_cudoviste();

                o.ID = p.ID;
                o.Naziv_cudovista = p.Naziv_cudovista;
                o.Podtip = p.Podtip;
                o.Vek = p.Vek;
                o.Da_li_postoji = p.Da_li_postoji;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static MagijskoCudovisteBasic azurirajMagijskoCudoviste(MagijskoCudovisteBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Magijsko_cudoviste o= s.Load<Cudovista.Entiteti.Magijsko_cudoviste>(p.ID);

                o.ID = p.ID;
                o.Naziv_cudovista = p.Naziv_cudovista;
                o.Podtip = p.Podtip;
                o.Vek = p.Vek;
                o.Da_li_postoji = p.Da_li_postoji;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }
        

        
        public static MagijskoCudovisteBasic vratiMagijskoCudoviste(int id)
        {
            MagijskoCudovisteBasic pb = new MagijskoCudovisteBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Magijsko_cudoviste o = s.Load<Cudovista.Entiteti.Magijsko_cudoviste>(id);
                pb = new MagijskoCudovisteBasic(o.ID, o.Podtip, o.Naziv_cudovista, o.Vek, o.Da_li_postoji);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }
        
        public static void obrisiMagijskoCudoviste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Magijsko_cudoviste o = s.Load<Cudovista.Entiteti.Magijsko_cudoviste>(id);
                o.Poseduje_sposobnosti.Clear();

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion MagijskaCudovista
        //treba da se doradi/ispravi

        #region NemagijskoCudoviste
        public static List<NemagijskoCudovistePregled> vratiSvaNemagijskaCudovista()
        {
            List<NemagijskoCudovistePregled> cudovista = new List<NemagijskoCudovistePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Nemagijsko_cudoviste> svaCudovista = from o in s.Query<Cudovista.Entiteti.Nemagijsko_cudoviste>()
                                                                                    select o;

                foreach (Cudovista.Entiteti.Nemagijsko_cudoviste p in svaCudovista)
                {
                    cudovista.Add(new NemagijskoCudovistePregled(p.ID, p.Da_li_zivi_u_vodi, p.Da_li_leti, p.Da_li_ima_rep, p.Da_li_je_otrovno, p.Da_li_ima_kandze, p.Broj_ociju, p.Broj_glava, p.Broj_ekstremiteta, p.Tezina, p.Duzina));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return cudovista;
        }

        public static void dodajNemagijskoCudoviste(NemagijskoCudovisteBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Nemagijsko_cudoviste o = new Cudovista.Entiteti.Nemagijsko_cudoviste();

                o.ID_Nemagijskog = p.ID_Nemagijskog;
                o.Da_li_zivi_u_vodi = p.Da_li_zivi_u_vodi;
                o.Da_li_leti = p.Da_li_leti;
                o.Da_li_ima_rep = p.Da_li_ima_rep;
                o.Da_li_je_otrovno = p.Da_li_je_otrovno;
                o.Da_li_ima_kandze = p.Da_li_ima_kandze;
                o.Broj_ociju = p.Broj_ociju;
                o.Broj_glava = p.Broj_glava;
                o.Broj_ekstremiteta = p.Broj_ekstremiteta;
                o.Duzina = p.Duzina;
                o.Tezina = p.Tezina;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static NemagijskoCudovisteBasic azurirajNemagijskoCudoviste(NemagijskoCudovisteBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Nemagijsko_cudoviste o = s.Load<Cudovista.Entiteti.Nemagijsko_cudoviste>(p.ID_Nemagijskog);
                o.ID_Nemagijskog = p.ID_Nemagijskog;
                o.Da_li_zivi_u_vodi = p.Da_li_zivi_u_vodi;
                o.Da_li_leti = p.Da_li_leti;
                o.Da_li_ima_rep = p.Da_li_ima_rep;
                o.Da_li_je_otrovno = p.Da_li_je_otrovno;
                o.Da_li_ima_kandze = p.Da_li_ima_kandze;
                o.Broj_ociju = p.Broj_ociju;
                o.Broj_glava = p.Broj_glava;
                o.Broj_ekstremiteta = p.Broj_ekstremiteta;
                o.Duzina = p.Duzina;
                o.Tezina = p.Tezina;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static NemagijskoCudovisteBasic vratiNemagijskoCudoviste(int id)
        {
            NemagijskoCudovisteBasic pb = new NemagijskoCudovisteBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Nemagijsko_cudoviste p = s.Load<Cudovista.Entiteti.Nemagijsko_cudoviste>(id);
                pb = new NemagijskoCudovisteBasic();


          
        s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiNemagijskoCudoviste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Nemagijsko_cudoviste o = s.Load<Cudovista.Entiteti.Nemagijsko_cudoviste>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion NemagijskoCudoviste
        //isto provera kao za magijsko


        #region Materijal

        #region Zlato
        public static void obrisiZlato(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zlato materijal = s.Load<Zlato>(id);

                s.Delete(materijal);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static ZlatoBasic vratiZlatoBasic(int id)
        {
            ZlatoBasic o = new ZlatoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zlato materijal = s.Load<Zlato>(id);

                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }
        public static List<MaterijalBasic> GetMaterijalInfos(int id)
        {
            List<MaterijalBasic> odInfos = new List<MaterijalBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Materijal> materijali = from o in s.Query<Materijal>()
                                                    where o.ID == id
                                                    select o;

                foreach (Materijal o in materijali)
                {
                    odInfos.Add(new MaterijalBasic(o.ID, o.Pripada_predmetu, o.Tip_Materijala));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static List<ZlatoPregled> vratiZlato(int Id)
        {
            List<ZlatoPregled> odInfos = new List<ZlatoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zlato> predmeti = from o in s.Query<Zlato>()
                                              where o.ID == Id
                                              select o;

                foreach (Zlato o in predmeti)
                {
                    odInfos.Add(new ZlatoPregled(o.ID, o.Pripada_predmetu, o.Tip_Materijala));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniZlato(ZlatoBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Zlato o = s.Load<Zlato>(materijal.ID);


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajZlato(ZlatoBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Zlato o = new Cudovista.Entiteti.Zlato();


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Zlato

        #region Srebro 

        public static SrebroBasic vratiSebroBasic(int id)
        {
            SrebroBasic o = new SrebroBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Srebro materijal = s.Load<Srebro>(id);

                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static void izmeniSrebro(SrebroBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Srebro o = s.Load<Srebro>(materijal.ID);


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajSrebro(SrebroBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Srebro o = new Cudovista.Entiteti.Srebro();


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion Srebro
        #region Dijamant

        public static DijamantBasic vratiDijamantBasic(int id)
        {
            DijamantBasic o = new DijamantBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Dijamant materijal = s.Load<Dijamant>(id);

                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static void izmeniDijamant(DijamantBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Dijamant o = s.Load<Dijamant>(materijal.ID);


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajDijamant(DijamantBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Dijamant o = new Cudovista.Entiteti.Dijamant();


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Dijamant

        #region Papir

        public static PapirBasic vratiPapirBasic(int id)
        {
            PapirBasic o = new PapirBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Papir materijal = s.Load<Papir>(id);

                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static void izmeniPapir(PapirBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Papir o = s.Load<Papir>(materijal.ID);


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajPapir(PapirBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Papir o = new Cudovista.Entiteti.Papir();


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Papir

        #region Metal

        public static MetalBasic vratiMetalBasic(int id)
        {
            MetalBasic o = new MetalBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Metal materijal = s.Load<Metal>(id);

                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static void izmeniMetal(MetalBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Metal o = s.Load<Metal>(materijal.ID);


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajMetal(MetalBasic materijal)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Metal o = new Cudovista.Entiteti.Metal();


                o.ID = materijal.ID;
                o.Pripada_predmetu = materijal.Pripada_predmetu;
                o.Tip_Materijala = materijal.Tip_Materijala;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Metal

        #endregion Materijal

        #region MagijskeSposobnosti
        public static List<MagijskeSposobnostiPregled> vratiSvaMagijskeSposobnosti()
        {
            List<MagijskeSposobnostiPregled> sposobnosti = new List<MagijskeSposobnostiPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Magijske_sposobnosti> sveSposobnosti = from o in s.Query<Cudovista.Entiteti.Magijske_sposobnosti>()
                                                                                      select o;

                foreach (Cudovista.Entiteti.Magijske_sposobnosti p in sveSposobnosti)
                {
                    sposobnosti.Add(new MagijskeSposobnostiPregled(p.ID, p.Naziv_sposobnosti, p.Da_li_je_odbrambena, p.Opis_sposobnosti, p.Id_cudovista));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return sposobnosti;
        }

        public static void dodajMagijskuSposobnost(MagijskeSposobnostiBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Magijske_sposobnosti o = new Cudovista.Entiteti.Magijske_sposobnosti();

                o.ID = p.ID;
                o.Naziv_sposobnosti = p.Naziv_sposobnosti;
                o.Da_li_je_odbrambena = p.Da_li_je_odbrambena;
                o.Opis_sposobnosti = p.Opis_sposobnosti;
                o.Id_cudovista = p.Id_cudovista;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static MagijskeSposobnostiBasic azurirajMagijskuSposobnost(MagijskeSposobnostiBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Magijske_sposobnosti o = s.Load<Cudovista.Entiteti.Magijske_sposobnosti>(p.ID);
                o.ID = p.ID;
                o.Naziv_sposobnosti = p.Naziv_sposobnosti;
                o.Da_li_je_odbrambena = p.Da_li_je_odbrambena;
                o.Opis_sposobnosti = p.Opis_sposobnosti;
                o.Id_cudovista = p.Id_cudovista;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static MagijskeSposobnostiBasic vratiMagijskuSposobnost(int id)
        {
            MagijskeSposobnostiBasic pb = new MagijskeSposobnostiBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Magijske_sposobnosti p = s.Load<Cudovista.Entiteti.Magijske_sposobnosti>(id);
                pb = new MagijskeSposobnostiBasic(p.ID, p.Naziv_sposobnosti, p.Da_li_je_odbrambena, p.Opis_sposobnosti, p.Id_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiMagijskuSposobnost(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Magijske_sposobnosti o = s.Load<Cudovista.Entiteti.Magijske_sposobnosti>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion MagijskeSposobnosti


        #region Protivmere
        public static List<ProtivmerePregled> vratiSveProtivmere()
        {
            List<ProtivmerePregled> protivmere = new List<ProtivmerePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Protivmere> sveProtivmere = from o in s.Query<Cudovista.Entiteti.Protivmere>()
                                                                           select o;

                foreach (Cudovista.Entiteti.Protivmere p in sveProtivmere)
                {
                    protivmere.Add(new ProtivmerePregled(p.ID, p.Naziv_protivmere, p.Da_li_uslovi, p.Opis_protivmere, p.Id_cudovista));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return protivmere;
        }

        public static void dodajProtivmeru(ProtivmereBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Protivmere o = new Cudovista.Entiteti.Protivmere();

                o.ID = p.ID;
                o.Naziv_protivmere = p.Naziv_protivmere;
                o.Opis_protivmere = p.Opis_protivmere;
                o.Da_li_uslovi = p.Da_li_uslovi;
                o.Id_cudovista = p.Id_cudovista;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static ProtivmereBasic azurirajProtivmeru(ProtivmereBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Protivmere o = s.Load<Cudovista.Entiteti.Protivmere>(p.ID);

                o.ID = p.ID;
                o.Naziv_protivmere = p.Naziv_protivmere;
                o.Opis_protivmere = p.Opis_protivmere;
                o.Da_li_uslovi = p.Da_li_uslovi;
                o.Id_cudovista = p.Id_cudovista;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static ProtivmereBasic vratiProtivmeru(int id)
        {
            ProtivmereBasic pb = new ProtivmereBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Protivmere p = s.Load<Cudovista.Entiteti.Protivmere>(id);
                pb = new ProtivmereBasic(p.ID, p.Naziv_protivmere, p.Da_li_uslovi, p.Opis_protivmere, p.Id_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiProtivmeru(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Protivmere o = s.Load<Cudovista.Entiteti.Protivmere>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Protivmere

        #region Bajalice
        public static List<BajalicePregled> vratiSveBajalice()
        {
            List<BajalicePregled> bajalice = new List<BajalicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Bajalice> sveBajalice = from o in s.Query<Cudovista.Entiteti.Bajalice>()
                                                                       select o;

                foreach (Cudovista.Entiteti.Bajalice p in sveBajalice)
                {
                    bajalice.Add(new BajalicePregled(p.ID, p.Bajalica, p.Id_cudovista));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return bajalice;
        }

        public static void dodajBajalicu(BajaliceBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Bajalice o = new Cudovista.Entiteti.Bajalice();

                o.ID = p.ID;
                o.Bajalica = p.Bajalica;
                o.Id_cudovista = p.Id_cudovista;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static BajaliceBasic azurirajBajalicu(BajaliceBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Bajalice o = s.Load<Cudovista.Entiteti.Bajalice>(p.ID);

                o.ID = p.ID;
                o.Bajalica = p.Bajalica;
                o.Id_cudovista = p.Id_cudovista;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static BajaliceBasic vratiBajalicu(int id)
        {
            BajaliceBasic pb = new BajaliceBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Bajalice p = s.Load<Cudovista.Entiteti.Bajalice>(id);
                pb = new BajaliceBasic(p.ID, p.Bajalica, p.Id_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiBajalicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Bajalice o = s.Load<Cudovista.Entiteti.Bajalice>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Bajalice

        #region SpecijalneSposobnosti
        public static List<SpecijalneSposobnostiPregled> vratiSveSpecijalneSposobnosti()
        {
            List<SpecijalneSposobnostiPregled> specijalneSposobnosti = new List<SpecijalneSposobnostiPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Specijalne_sposobnosti> sveSpecijalneSposobnosti = from o in s.Query<Cudovista.Entiteti.Specijalne_sposobnosti>()
                                                                                                  select o;

                foreach (Cudovista.Entiteti.Specijalne_sposobnosti p in sveSpecijalneSposobnosti)
                {
                    specijalneSposobnosti.Add(new SpecijalneSposobnostiPregled(p.ID, p.Spec_sposobnosti, p.Id_cudovista));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return specijalneSposobnosti;
        }

        public static void dodajSpecijalnuSposobnost(SpecijalneSposobnostiBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Specijalne_sposobnosti o = new Cudovista.Entiteti.Specijalne_sposobnosti();

                o.ID = p.ID;
                o.Spec_sposobnosti = p.Spec_sposobnosti;
                o.Id_cudovista = p.Id_cudovista;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static SpecijalneSposobnostiBasic azurirajSpecijalnuSposobnost(SpecijalneSposobnostiBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Specijalne_sposobnosti o = s.Load<Cudovista.Entiteti.Specijalne_sposobnosti>(p.ID);

                o.ID = p.ID;
                o.Spec_sposobnosti = p.Spec_sposobnosti;
                o.Id_cudovista = p.Id_cudovista;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static SpecijalneSposobnostiBasic vratiSpecijalnuSposobnost(int id)
        {
            SpecijalneSposobnostiBasic pb = new SpecijalneSposobnostiBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Specijalne_sposobnosti p = s.Load<Cudovista.Entiteti.Specijalne_sposobnosti>(id);
                pb = new SpecijalneSposobnostiBasic(p.ID, p.Spec_sposobnosti, p.Id_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiSpecijalnuSposobnosti(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Specijalne_sposobnosti p = s.Load<Cudovista.Entiteti.Specijalne_sposobnosti>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion SpecijalneSposobnosti

        #region Lokacija

        #region Ostrvo
        public static void obrisiOstrvo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ostrvo lokacija = s.Load<Ostrvo>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static OstrvoBasic vratiOstrvoBasic(int id)
        {
            OstrvoBasic o = new OstrvoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Ostrvo lokacija = s.Load<Ostrvo>(id);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }
        public static List<LokacijaBasic> GetLokacijaInfos(int id)
        {
            List<LokacijaBasic> odInfos = new List<LokacijaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lokacija> lokacije = from o in s.Query<Lokacija>()
                                                 where o.ID == id
                                                 select o;

                foreach (Lokacija o in lokacije)
                {
                    odInfos.Add(new LokacijaBasic(o.ID, o.Naziv_lokacije, o.Tip_lokacije, o.Zemlja, o.Blago, o.Borio_se));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static List<OstrvoPregled> vratiOstrvo(int Id)
        {
            List<OstrvoPregled> odInfos = new List<OstrvoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ostrvo> predmeti = from o in s.Query<Ostrvo>()
                                               where o.ID == Id
                                               select o;

                foreach (Ostrvo o in predmeti)
                {
                    odInfos.Add(new OstrvoPregled(o.ID, o.Naziv_lokacije, o.Tip_lokacije, o.Zemlja, o.Blago, o.Borio_se));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniOstrvo(OstrvoBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Ostrvo o = s.Load<Ostrvo>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajOstrvo(OstrvoBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Ostrvo o = new Cudovista.Entiteti.Lokacija.Ostrvo();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Ostrvo
        #region Piramida

        public static void obrisiPiramidu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Piramida lokacija = s.Load<Piramida>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static PiramidaBasic vratiPiramidaBasic(int id)
        {
            PiramidaBasic o = new PiramidaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Piramida lokacija = s.Load<Piramida>(id);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static List<PiramidaPregled> vratiPiramidu(int Id)
        {
            List<PiramidaPregled> odInfos = new List<PiramidaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Piramida> predmeti = from o in s.Query<Piramida>()
                                                 where o.ID == Id
                                                 select o;

                foreach (Piramida o in predmeti)
                {
                    odInfos.Add(new PiramidaPregled(o.ID, o.Naziv_lokacije, o.Tip_lokacije, o.Zemlja, o.Blago, o.Borio_se));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniPiramidu(PiramidaBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Piramida o = s.Load<Piramida>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajPiramidu(PiramidaBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Piramida o = new Cudovista.Entiteti.Lokacija.Piramida();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Piramida
        #region GradDuhova

        public static void obrisiGradDuhova(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad_duhova lokacija = s.Load<Grad_duhova>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static PiramidaBasic vratiGradDuhovaBasic(int id)
        {
            PiramidaBasic o = new PiramidaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Grad_duhova lokacija = s.Load<Grad_duhova>(id);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static List<GradDuhovaPregled> vratiGradDuhova(int Id)
        {
            List<GradDuhovaPregled> odInfos = new List<GradDuhovaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Grad_duhova> predmeti = from o in s.Query<Grad_duhova>()
                                                    where o.ID == Id
                                                    select o;

                foreach (Grad_duhova o in predmeti)
                {
                    odInfos.Add(new GradDuhovaPregled(o.ID, o.Naziv_lokacije, o.Tip_lokacije, o.Zemlja, o.Blago, o.Borio_se));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniGradDuhova(GradDuhovaBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Grad_duhova o = s.Load<Grad_duhova>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajGradDuhova(GradDuhovaBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Grad_duhova o = new Cudovista.Entiteti.Lokacija.Grad_duhova();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion GradDuhova

        #region UkletiZamak

        public static void obrisiUkletiZamak(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ukleti_zamak lokacija = s.Load<Ukleti_zamak>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static UkletiZamakBasic vratiUkletiZamakBasic(int id)
        {
            UkletiZamakBasic o = new UkletiZamakBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Ukleti_zamak lokacija = s.Load<Ukleti_zamak>(id);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static List<UkletiZamakPregled> vratiUkletiZamak(int Id)
        {
            List<UkletiZamakPregled> odInfos = new List<UkletiZamakPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ukleti_zamak> predmeti = from o in s.Query<Ukleti_zamak>()
                                                     where o.ID == Id
                                                     select o;

                foreach (Ukleti_zamak o in predmeti)
                {
                    odInfos.Add(new UkletiZamakPregled(o.ID, o.Naziv_lokacije, o.Tip_lokacije, o.Zemlja, o.Blago, o.Borio_se));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniUkletiZamak(UkletiZamakBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Ukleti_zamak o = s.Load<Ukleti_zamak>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajUkletiZamak(UkletiZamakBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Ukleti_zamak o = new Cudovista.Entiteti.Lokacija.Ukleti_zamak();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion UkletiZamak
        #region Pecina

        public static void obrisiPecinu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pecina lokacija = s.Load<Pecina>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static PecinaBasic vratiPecinaBasic(int id)
        {
            PecinaBasic o = new PecinaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Pecina lokacija = s.Load<Pecina>(id);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }

        public static List<PecinaPregled> vratiPecinu(int Id)
        {
            List<PecinaPregled> odInfos = new List<PecinaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pecina> predmeti = from o in s.Query<Pecina>()
                                               where o.ID == Id
                                               select o;

                foreach (Pecina o in predmeti)
                {
                    odInfos.Add(new PecinaPregled(o.ID, o.Naziv_lokacije, o.Tip_lokacije, o.Zemlja, o.Blago, o.Borio_se));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniPecina(PecinaBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Pecina o = s.Load<Pecina>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajPecina(PecinaBasic lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Lokacija.Pecina o = new Cudovista.Entiteti.Lokacija.Pecina();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Borio_se = lokacija.Borio_se;


                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Pecina

        #endregion Lokacija

        #region Zastita

        #region Duh
        public static void obrisiDuha(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Duh zastita = s.Load<Duh>(id);

                s.Delete(zastita);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static DuhBasic vratiDuhaBasic(int id)
        {
            DuhBasic o = new DuhBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Duh zastita = s.Load<Duh>(id);

                o.ID = zastita.ID;
                o.Naziv_zastite = zastita.Naziv_zastite;
                o.Tip_zastite = zastita.Tip_zastite;
                o.Id_lokacije = zastita.Id_lokacije;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;

        }
        public static List<ZastitaPregled> VratiSveZastiteJednogPredmeta(int id)
        {
            List<ZastitaPregled> odInfos = new List<ZastitaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zastita> lokacije = from o in s.Query<Zastita>()
                                                 where o.ID == id
                                                 select o;

                foreach (Zastita o in lokacije)
                {
                    odInfos.Add(new ZastitaPregled(o.ID, o.Naziv_zastite, o.Tip_zastite, o.Id_lokacije));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static List<DuhPregled> vratiDuha(int Id)
        {
            List<DuhPregled> odInfos = new List<DuhPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Duh> predmeti = from o in s.Query<Duh>()
                                               where o.ID == Id
                                               select o;

                foreach (Duh o in predmeti)
                {
                    odInfos.Add(new DuhPregled(o.ID, o.Naziv_zastite, o.Tip_zastite, o.Id_lokacije));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static void izmeniDuha(DuhBasic zastita)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Duh o = s.Load<Duh>(zastita.ID);

                o.ID = zastita.ID;
                o.Naziv_zastite = zastita.Naziv_zastite;
                o.Tip_zastite = zastita.Tip_zastite;
                o.Id_lokacije = zastita.Id_lokacije;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajDuha(DuhBasic zastita)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Duh o = new Cudovista.Entiteti.Duh();

                o.ID = zastita.ID;
                o.Naziv_zastite = zastita.Naziv_zastite;
                o.Tip_zastite = zastita.Tip_zastite;
                o.Id_lokacije = zastita.Id_lokacije;



                //Cudovista.Entiteti.Predmet p = s.Load<Cudovista.Entiteti.Predmet>(predmet.Id_cudovista.ID);
                //o.PripadaProdavnici = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Duh
        #endregion Zastita

        #region ZiviNa
        public static List<ZiviNaPregled> vratiSveZiviNa()
        {
            List<ZiviNaPregled> ziviNa = new List<ZiviNaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudovista.Entiteti.Zivi_na> sveZiviNa = from o in s.Query<Cudovista.Entiteti.Zivi_na>()
                                                                       select o;

                foreach (Cudovista.Entiteti.Zivi_na p in sveZiviNa)
                {
                    ziviNa.Add(new ZiviNaPregled(p.ID, /* int Id_lokacije, int Id_predstavnika,*/  p.predstavnikZivi, p.lokacijaZivota));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ziviNa;
        }

        public static void dodajZiviNa(ZiviNaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Zivi_na o = new Cudovista.Entiteti.Zivi_na();

                o.ID = p.ID;
                o.predstavnikZivi = p.predstavnikZivi;
                o.lokacijaZivota = p.lokacijaZivota;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static ZiviNaBasic azurirajZiviNa(ZiviNaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Zivi_na o = s.Load<Cudovista.Entiteti.Zivi_na>(p.ID);

                o.ID = p.ID;
                o.predstavnikZivi = p.predstavnikZivi;
                o.lokacijaZivota = p.lokacijaZivota;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static ZiviNaBasic vratiZiviNa(int id)
        {
            ZiviNaBasic pb = new ZiviNaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Zivi_na p = s.Load<Cudovista.Entiteti.Zivi_na>(id);
                pb = new ZiviNaBasic(p.ID, /* int Id_lokacije, int Id_predstavnika,*/  p.predstavnikZivi, p.lokacijaZivota);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiZiviNa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudovista.Entiteti.Zivi_na o = s.Load<Cudovista.Entiteti.Zivi_na>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion ZiviNa

    }

}
