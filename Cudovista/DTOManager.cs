using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using NHibernate;
using Cudovista.Entiteti;

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
        public static List<PredmetBasic> GetOdInfos(int CudovisteId)
        {
            List<PredmetBasic> odInfos = new List<PredmetBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predmet> predmeti = from o in s.Query<Predmet>()
                                                   where o.Id_cudovista.ID == CudovisteId
                                                select o;

                foreach (Predmet o in predmeti)
                {
                    odInfos.Add(new PredmetBasic(o.ID, o.Id_cudovista, o.ID_Materijala, o.Tip_Predmeta));
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
        public static void izmeniOdeljenjeDo5(KrstBasic predmet)
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
        #endregion Predmet

    }
}
