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

                Nemagijsko_cudoviste o = s.Load<Nemagijsko_cudoviste>(1);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(o);
                //s.Delete("from Odeljenje");

                s.Flush();
                s.Close();
                this.popuniPodacima();

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
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Naziv_cudovista, p.Podtip, p.Vek.ToString(), p.Da_li_zivi_u_vodi.ToString(), p.Da_li_leti.ToString(), p.Da_li_ima_rep.ToString(), p.Da_li_je_otrovno.ToString(), p.Da_li_ima_kandze.ToString(), p.Broj_ociju.ToString(), p.Broj_glava.ToString(), p.Broj_ekstremiteta.ToString(), p.Tezina.ToString(), p.Duzina.ToString() });
                listNemagijska.Items.Add(item);

            }

  

            listNemagijska.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajNemagijsko_Click(object sender, EventArgs e)
        {
            DodajNemagijsko formaDodajC = new DodajNemagijsko();
            formaDodajC.ShowDialog();
            this.popuniPodacima();

           
        }

        private void NemagijskaCudovistaForma_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }
    }
    }

