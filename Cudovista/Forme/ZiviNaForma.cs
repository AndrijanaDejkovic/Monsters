using Cudovista.Entiteti;
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
using static Cudovista.Entiteti.Lokacija;

namespace Cudovista.Forme
{
    public partial class ZiviNaForma : Form
    {

        public void popuniPodacima()
        {

            listZiviNa.Items.Clear();
            List<ZiviNaPregled> podaci = DTOManager.vratiSveZiviNa();



            foreach (ZiviNaPregled p in podaci)
            {
                string pom1, pom2;
                if (p.predstavnikZivi != null)
                    pom1 = p.predstavnikZivi.ID.ToString();
                else
                    pom1 = "Nema predstavnika";

                if (p.lokacijaZivota!= null)
                    pom2 = p.lokacijaZivota.ID.ToString();
                else
                    pom2 = "Nema lokacije";


                ListViewItem item = new ListViewItem(new string[] { pom1, pom2});
                listZiviNa.Items.Add(item);

            }



            listZiviNa.Refresh();
        }
        public ZiviNaForma()
        {
            InitializeComponent();
            listZiviNa.View = View.Details;

        }

        private void listZiviNa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajZiviNa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Zivi_na o = new Entiteti.Zivi_na();

                Ostrvo p = new Ostrvo();

                s.Save(p);
                o.lokacijaZivota = p;
                o.Id_lokacije = p.ID;
                Predstavnik p2 = new Predstavnik();

                s.Save(p2);

                o.predstavnikZivi = p2;
                o.Id_predstavnika = p2.ID;

                s.Save(o);

                //dodaje se u listi predstavnika ziviNa objekat
                p2.ZiveNaLokacijama.Add(o);

                //dodaje se u listi lokacija ziviNa objekat
                p.ZivePredstavnici.Add(o);


                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiZiviNa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivi_na o = s.Load<Zivi_na>(1);

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

        private void azurirajZiviNa_Click(object sender, EventArgs e)
        {

        }
    }
}
