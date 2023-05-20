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
    public partial class ZastitaForma : Form
    {
        public ZastitaForma()
        {
            InitializeComponent();
        }

        public void popuniPodacima()
        {

            listZastita.Items.Clear();
            List<ZastitaPregled> podaci = DTOManager.VratiSveZastiteJednogPredmeta(1);



            foreach (ZastitaPregled p in podaci)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Naziv_zastite, p.Tip_zastite, p.Id_lokacije.ToString() });
                listZastita.Items.Add(item);

            }



            listZastita.Refresh();
        }

        private void dodajDuha_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ostrvo m = new Ostrvo();

                Duh o = new Duh();
                o.Naziv_zastite = "Duhov udarac";
                o.Id_lokacije = m;
                s.Save(m);

                s.Save(o);

                //p.Predmeti.Add(o);


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiDuha_Click(object sender, EventArgs e)
        {

        }

        private void azurirajDuha_Click(object sender, EventArgs e)
        {

        }

        private void dodajZmaja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ostrvo m = new Ostrvo();

                Zmaj o = new Zmaj();
                o.Naziv_zastite = "Zmajeva kugla";
                o.Id_lokacije = m;
                s.Save(m);

                s.Save(o);


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiZmaja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zastita o = s.Get<Zastita>(1);

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

        private void azurirajZmaja_Click(object sender, EventArgs e)
        {

        }

        private void dodajKletvu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ostrvo m = new Ostrvo();

                Kletva o = new Kletva();
                o.Naziv_zastite = "Crna kletva";
                o.Id_lokacije = m;
                s.Save(m);

                s.Save(o);


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void azurirajKletvu_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
