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

        }

        public void popuniPodacima()
        {

            listPredstavnik.Items.Clear();
            List<PredstavnikPregled> podaci = DTOManager.vratiSvePredstavnike();



            foreach (PredstavnikPregled p in podaci)
            {
                

                ListViewItem item = new ListViewItem(new string[] {  p.Starost.ToString(), p.Ime_predstavnika, p.DatumSusreta.ToString(), p.Ishod, p.Id_cudovista.ToString(), p.Id_lokacije.ToString(), p.IDPredstavnika.ToString() });
                listPredstavnik.Items.Add(item);

            }



            listPredstavnik.Refresh();
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


                p.Ime_predstavnika = "Gorila";
                p.Starost = 98;
                p.Datum_susreta = DateTime.Now;
                p.Ishod = "Poraz";
                p.Id_cudovista = s.Load<Cudovista.Entiteti.Cudoviste>(50);
                p.Id_lokacije = s.Load<Cudovista.Entiteti.Lokacija>(5);
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

                Predstavnik o = s.Load<Predstavnik>(3);

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
                Cudovista.Entiteti.Predstavnik p = s.Load<Cudovista.Entiteti.Predstavnik>(2);

                //objekat se modifikuje potpuno nezavisno od sesije
                p.Ime_predstavnika = "Egzodija";

                //otvara se nova sesija


                //poziva se Update i objekat se povezuje sa novom sesijom
                s.Update(p);
                s.Flush();
                s.Close();
                MessageBox.Show(p.Ime_predstavnika);


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
