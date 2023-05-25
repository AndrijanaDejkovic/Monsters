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
    
    public partial class IzlistajSposobnostiForma : Form
    {
        public MagijskoCudovisteBasic cudoviste;
        public IzlistajSposobnostiForma(MagijskoCudovisteBasic M)
        {
            InitializeComponent();
            this.cudoviste = M;
        }
        public void popuni()
        {
            listaSposobnosti.Items.Clear();
            List<MagijskeSposobnostiPregled> podaci = DTOManager.vratiSposobnostiMagijskogCudovista(cudoviste.ID);

            foreach (MagijskeSposobnostiPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Naziv_sposobnosti, p.Opis_sposobnosti, p.Da_li_je_odbrambena.ToString() });
                listaSposobnosti.Items.Add(item);

            }
            listaSposobnosti.Refresh();
        }

        private void IzlistajSposobnostiForma_Load(object sender, EventArgs e)
        {
            popuni();
            this.Text = $"AZURIRANJE CUDOVISTA {cudoviste.Naziv_cudovista.ToUpper()}";
        }
    }
}
