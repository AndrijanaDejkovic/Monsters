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
    public partial class CudovisteForma : Form
    {
        public CudovisteForma()
        {
            InitializeComponent();
        }


        private void Lista_Cudovista_Enter(object sender, EventArgs e)
        {

        }

        public void popuniPodacima()
        {


            listaCudovista.Items.Clear();
            List<MagijskoCudovistePregled> podaci = DTOManager.vratiSvaMagijskaCudovista();



            foreach (MagijskoCudovistePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Naziv_cudovista, p.Vek.ToString(), p.Podtip, p.Da_li_postoji.ToString()});
                listaCudovista.Items.Add(item);

            }
            listaCudovista.Refresh();
        }
        private void btnDodajCudoviste_Click(object sender, EventArgs e)
        {
            DodajCudoviste formaDodajC = new DodajCudoviste();
            formaDodajC.ShowDialog();
            this.popuniPodacima();

        }
    }
}
