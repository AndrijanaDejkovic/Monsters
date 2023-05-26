using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cudovista.Forme
{
    public partial class FormaTest : Form
    {
        public FormaTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //OVO JE ZA CUDOVISTE
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Cudoviste p = s.Get<Cudovista.Entiteti.Cudoviste>(1);

                MessageBox.Show(p.Naziv_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //OVO JE ZA CUDOVISTE
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Cudoviste p = s.Get<Cudovista.Entiteti.Cudoviste>(3);

                MessageBox.Show(p.Naziv_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Legende p = s.Get<Cudovista.Entiteti.Legende>(2);

                MessageBox.Show(p.Tekst);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void findBajalica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Bajalice p = s.Get<Cudovista.Entiteti.Bajalice>(2);

                MessageBox.Show(p.Bajalica);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Nemagijsko_cudoviste p = s.Get<Cudovista.Entiteti.Nemagijsko_cudoviste>(1);

                MessageBox.Show(p.Naziv_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void findProtivmera_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Protivmere p = s.Get<Cudovista.Entiteti.Protivmere>(2);

                MessageBox.Show(p.Naziv_protivmere);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void findSpecSposobnost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Specijalne_sposobnosti p = s.Get<Cudovista.Entiteti.Specijalne_sposobnosti>(1);

                MessageBox.Show(p.Spec_sposobnosti);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void findLovac_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Lovac p = s.Get<Cudovista.Entiteti.Lovac>(2);

                MessageBox.Show(p.Ime_lovca);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void findMagijsko_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Magijsko_cudoviste p = s.Get<Cudovista.Entiteti.Magijsko_cudoviste>(100);

                MessageBox.Show(p.Naziv_cudovista);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Materijal_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Materijal p = s.Get<Cudovista.Entiteti.Materijal>(5);

                MessageBox.Show(p.GetType().ToString().Split('.').Last());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Predmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Predmet p = s.Get<Cudovista.Entiteti.Predmet>(1);

                MessageBox.Show(p.GetType().ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Zastita_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Zastita p = s.Get<Cudovista.Entiteti.Zastita>(1);

                MessageBox.Show(p.Naziv_zastite);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Lokacija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Lokacija p = s.Get<Cudovista.Entiteti.Lokacija>(1);

                MessageBox.Show(p.Naziv_lokacije);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void ZiviNa_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                var p = s.Get<Cudovista.Entiteti.Zivi_na>(2);

                MessageBox.Show(p.ID.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
