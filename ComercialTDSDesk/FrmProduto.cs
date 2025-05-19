using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            ofdObterImagem.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png";
            if(ofdObterImagem.ShowDialog() == DialogResult.OK)
            {
                picImagem.Image = Image.FromFile(ofdObterImagem.FileName); //arquivo
            }
        }
    }
}
