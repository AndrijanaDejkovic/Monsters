using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Cudovista.Entiteti;

namespace Cudovista.Forme
{
    public partial class PredstavnikForm : Form
    {
        public PredstavnikForm()
        {
            InitializeComponent();
            listPredstavnik.View = View.Details;

        }

        public void popuniPodacima()
        {

            listPredstavnik.Items.Clear();
            List<PredstavnikPregled> podaci = DTOManager.vratiSvePredstavnike();



            foreach (PredstavnikPregled p in podaci)
            {
                

                ListViewItem item = new ListViewItem(new string[] { p.Ime_predstavnika, p.Starost.ToString(), p.DatumSusreta.ToString(), p.Ishod, p.Id_cudovista.ToString(), p.Id_lokacije.ToString() });
                listPredstavnik.Items.Add(item);

            }



            listPredstavnik.Refresh();
            listPredstavnik.View = View.Details;
        }

        private void PredstavnikForm_Load(object sender, EventArgs e)
        {

        }

        private void listPredstavnik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajPredstavnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Predstavnik p = new Entiteti.Predstavnik();

                Entiteti.Cudoviste c = new Entiteti.Cudoviste()
                {

                    Vek = 10,
                    Naziv_cudovista = "Vanzemaljac",
                    Podtip = "Vanzemaljac"
                };

                Entiteti.Lokacija.Ostrvo lokacija = new Entiteti.Lokacija.Ostrvo();

                //s.Save(lokacija);
                s.Save(c);

                p.Ime_predstavnika = "Veliko cudoviste";
                p.Starost = 55;
                p.Datum_susreta = DateTime.Now;
                p.Ishod = "Poraz";
                p.Id_cudovista = c;
                //p.Id_lokacije = lokacija;
                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiPredstavnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnik o = s.Load<Predstavnik>(4);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(o);
                //s.Delete("from Odeljenje");

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void azurirajPredstavnika_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Predstavnik p = s.Load<Cudovista.Entiteti.Predstavnik>(1);
                s.Close();

                //objekat se modifikuje potpuno nezavisno od sesije
                p.Ime_predstavnika = "Egzodija";

                //otvara se nova sesija

                ISession s1 = DataLayer.GetSession();

                //poziva se Update i objekat se povezuje sa novom sesijom
                s1.Update(p);
                s1.Flush();
                s1.Close();
                MessageBox.Show(p.Ime_predstavnika);


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
