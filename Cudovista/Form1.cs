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

namespace Cudovista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void findNameCudoviste_Click(object sender, EventArgs e)
        {
            try
            {
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

        /*private void button2_Click(object sender, EventArgs e)
        {
            try
            {
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

        }*/

        /*private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Cudovista.Entiteti.Cudoviste p = s.Get<Cudovista.Entiteti.Cudoviste>(1);

                MessageBox.Show(p.ID.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }*/


    }
}
