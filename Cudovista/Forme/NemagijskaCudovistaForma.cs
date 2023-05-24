using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cudovista.Entiteti;
using NHibernate;

namespace Cudovista.Forme
{
    public partial class NemagijskaCudovistaForma : Form
    {
        public NemagijskaCudovistaForma()
        {
            InitializeComponent();
            listNemagijska.View = View.Details;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nemagijsko_cudoviste o = s.Load<Nemagijsko_cudoviste>(4);

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

        public void popuniPodacima()
        {

            listNemagijska.Items.Clear();
            List<NemagijskoCudovistePregled> podaci = DTOManager.vratiSvaNemagijskaCudovista();



            foreach (NemagijskoCudovistePregled p in podaci)
            {
                string pom1, pom2, pom3, pom4, pom5, pom6;
                if (p.Da_li_zivi_u_vodi == 1)
                    pom1 = "Da";
                else
                    pom1 = "Ne";
                if (p.Da_li_leti == 1)
                    pom2 = "Da";
                else
                    pom2 = "Ne";
                if (p.Da_li_ima_rep == 1)
                    pom3 = "Da";
                else
                    pom3 = "Ne";
                if (p.Da_li_je_otrovno == 1)
                    pom4 = "Da";
                else
                    pom4 = "Ne";
                if (p.Da_li_ima_kandze == 1)
                    pom5 = "Da";
                else
                    pom5 = "Ne";
                ListViewItem item = new ListViewItem(new string[] {pom1, pom2, pom3, pom4, pom5, p.Broj_ociju.ToString(), p.Broj_glava.ToString(), p.Broj_ekstremiteta.ToString(), p.Duzina.ToString(), p.Tezina.ToString() });
                listNemagijska.Items.Add(item);

            }



            listNemagijska.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void DodajNemagijsko_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Nemagijsko_cudoviste o = new Entiteti.Nemagijsko_cudoviste();

                o.Da_li_zivi_u_vodi = 1;
                o.Da_li_leti = 0;
                o.Da_li_ima_rep = 1;
                o.Da_li_je_otrovno = 1;
                o.Da_li_ima_kandze = 0;
                o.Broj_ociju = 2;
                o.Broj_glava = 1;
                o.Broj_ekstremiteta = 0;
                o.Duzina = 25;
                o.Tezina = 150;
                s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void AzurirajNemagijsko_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Nemagijsko_cudoviste p = s.Load<Cudovista.Entiteti.Nemagijsko_cudoviste>(1);
                s.Close();

                //objekat se modifikuje potpuno nezavisno od sesije
                p.Broj_ociju = 20;

                //otvara se nova sesija

                ISession s1 = DataLayer.GetSession();

                //poziva se Update i objekat se povezuje sa novom sesijom
                s1.Update(p);
                s1.Flush();
                s1.Close();
                MessageBox.Show(p.Broj_ociju.ToString());

                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
