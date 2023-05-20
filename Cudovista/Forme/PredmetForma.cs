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
    public partial class PredmetForma : Form
    {
        public PredmetForma()
        {
            InitializeComponent();
        }

        public void popuniPodacima()
        {

            listPredmeti.Items.Clear();
            List<PredmetPregled> podaci = DTOManager.vratiPredmeteJednogOdeljenja(1);



            foreach (PredmetPregled p in podaci)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Id_cudovista.ToString(), p.ID_Materijala.ToString(), p.Tip_Predmeta});
                listPredmeti.Items.Add(item);

            }



            listPredmeti.Refresh();
        }
        private void listPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajLobanju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zlato m = new Zlato();
                Entiteti.Cudoviste p = new Entiteti.Cudoviste()
                {

                    Vek = 10,
                    Naziv_cudovista = "Crni gepard",
                    Podtip = "Geaprd"
                };

                Lobanja o = new Lobanja();
                o.Id_cudovista = p;
                o.ID_Materijala = m;
                s.Save(p);
                s.Save(m);

                s.Save(o);

                //p.Predmeti.Add(o);

                s.Save(p);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiLobanju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet o = s.Get<Predmet>(1);

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

        private void azurirajLobanju_Click(object sender, EventArgs e)
        {

        }

        private void dodajKrst_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zlato m = new Zlato();
                Entiteti.Cudoviste p = new Entiteti.Cudoviste()
                {

                    Vek = 10,
                    Naziv_cudovista = "Crni Slon",
                    Podtip = "Slon"
                };

                Krst o = new Krst();
                o.Id_cudovista = p;
                o.ID_Materijala = m;
                s.Save(p);
                s.Save(m);

                s.Save(o);

                //p.Predmeti.Add(o);

                s.Save(p);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiKrst_Click(object sender, EventArgs e)
        {
            
        }

        private void azurirajKrst_Click(object sender, EventArgs e)
        {

        }

        private void dodajMac_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zlato m = new Zlato();
                Entiteti.Cudoviste p = new Entiteti.Cudoviste()
                {

                    Vek = 10,
                    Naziv_cudovista = "Crni macak",
                    Podtip = "Macak"
                };

                Mac o = new Mac();
                o.Id_cudovista = p;
                o.ID_Materijala = m;
                s.Save(p);
                s.Save(m);

                s.Save(o);

                //p.Predmeti.Add(o);

                s.Save(p);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiMac_Click(object sender, EventArgs e)
        {

        }

        private void azurirajMac_Click(object sender, EventArgs e)
        {

        }

        private void dodajKnjigu_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                Zlato m = new Zlato();
                Entiteti.Cudoviste p = new Entiteti.Cudoviste()
                {

                    Vek = 10,
                    Naziv_cudovista = "Crni tornado",
                    Podtip = "tornado"
                };

                Knjiga o = new Knjiga();
                o.Id_cudovista = p;
                o.ID_Materijala = m;
                s.Save(p);
                s.Save(m);

                s.Save(o);

                //p.Predmeti.Add(o);

                s.Save(p);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiKnjigu_Click(object sender, EventArgs e)
        {

        }

        private void azurirajKnjigu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
