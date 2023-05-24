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
    public partial class ProtivmereForma : Form
    {
        public ProtivmereForma()
        {
            InitializeComponent();
            listProtivmere.View = View.Details;

        }

        public void popuniPodacima()
        {

            listProtivmere.Items.Clear();
            List<ProtivmerePregled> podaci = DTOManager.vratiSveProtivmere();



            foreach (ProtivmerePregled p in podaci)
            {
                string pom;
                if (p.Da_li_uslovi == 1)
                    pom = "Da";
                else
                    pom = "Ne";

                ListViewItem item = new ListViewItem(new string[] { p.Naziv_protivmere, p.Opis_protivmere, pom, p.Id_cudovista.ToString()});
                listProtivmere.Items.Add(item);

            }



            listProtivmere.Refresh();
            listProtivmere.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Protivmere o = new Entiteti.Protivmere();

                Entiteti.Cudoviste p = new Entiteti.Cudoviste()
                {

                    Vek = 10,
                    Naziv_cudovista = "Snesko",
                    Podtip = "Snesko"
                };

                s.Save(p);

                o.Naziv_protivmere = "Stit";
                o.Opis_protivmere = "Imun na moci 10 minuta";
                o.Da_li_uslovi = 0;
                o.Id_cudovista = p;
                
                s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiProtivmeru_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Protivmere o = s.Load<Protivmere>(4);

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

        private void listProtivmere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void azurirajProtivmeru_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Protivmere p = s.Load<Cudovista.Entiteti.Protivmere>(1);
                s.Close();

                //objekat se modifikuje potpuno nezavisno od sesije
                p.Opis_protivmere = "Pojacava mu imunitet";

                //otvara se nova sesija

                ISession s1 = DataLayer.GetSession();

                //poziva se Update i objekat se povezuje sa novom sesijom
                s1.Update(p);
                s1.Flush();
                s1.Close();
                MessageBox.Show(p.Opis_protivmere);


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
 }

