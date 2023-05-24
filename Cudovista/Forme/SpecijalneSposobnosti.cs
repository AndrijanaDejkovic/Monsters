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
    public partial class SpecijalneSposobnosti : Form
    {
        public SpecijalneSposobnosti()
        {
            InitializeComponent();
            listSpecSposobnosti.View = View.Details;

        }

        public void popuniPodacima()
        {

            listSpecSposobnosti.Items.Clear();
            List<SpecijalneSposobnostiPregled> podaci = DTOManager.vratiSveSpecijalneSposobnosti();



            foreach (SpecijalneSposobnostiPregled p in podaci)
            {

                ListViewItem item = new ListViewItem(new string[] { p.Spec_sposobnosti, p.Id_cudovista.ToString() });
                listSpecSposobnosti.Items.Add(item);

            }



            listSpecSposobnosti.Refresh();
        }

        private void listSpecSposobnosti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajSpecSposobnost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Specijalne_sposobnosti o = new Entiteti.Specijalne_sposobnosti();

                o.Spec_sposobnosti = "Moze da pobedi svako cudoviste";
                //p.Id_cudovista = 1;
                //p.Id_lokacije = 1;
                s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void obrisiSpecSposobnost_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Specijalne_sposobnosti o = s.Load<Specijalne_sposobnosti>(4);

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

        private void azurirajSpecSposobnost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Specijalne_sposobnosti p = s.Load<Cudovista.Entiteti.Specijalne_sposobnosti>(1);
                s.Close();

                //objekat se modifikuje potpuno nezavisno od sesije
                p.Spec_sposobnosti = "Moze da nauci da skace visoko";

                //otvara se nova sesija

                ISession s1 = DataLayer.GetSession();

                //poziva se Update i objekat se povezuje sa novom sesijom
                s1.Update(p);
                s1.Flush();
                s1.Close();
                MessageBox.Show(p.Spec_sposobnosti);


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
