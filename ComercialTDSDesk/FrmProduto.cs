using ComercialTDSClass;
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
            if (ofdObterImagem.ShowDialog() == DialogResult.OK)
            {
                picImagem.Image = Image.FromFile(ofdObterImagem.FileName); //arquivo
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            byte[] imgBytes;
            MemoryStream ms = new();
            picImagem.Image.Save(ms, picImagem.Image.RawFormat);
            imgBytes = ms.ToArray();

            Produto produto = new
                (
                    txtCodBarras.Text,
                    txtDescricao.Text,
                    (double)nudValorUnit.Value,
                    txtUnidadeVenda.Text,
                    Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                    (double)nudEstoqueMinimo.Value,
                    (double)nudClasseDesconto.Value,
                    imgBytes
                );
            produto.Inserir();
            if (produto.Id > 0)
                MessageBox.Show($"Produto {produto.Id} gravado com sucesso!");
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Categoria.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            if(txtCodBarras.Text.Length > 7)
            {
                var produto = Produto.ObterPorCodBarras(txtCodBarras.Text);
                txtCodBarras.Text = produto.CodBarras;
                txtDescricao.Text = produto.Descricao;
                nudValorUnit.Value = Convert.ToDecimal(produto.ValorUnit);
                txtUnidadeVenda.Text = produto.UnidadeVenda;
                nudClasseDesconto.Value = Convert.ToDecimal(produto.ClasseDesconto);
                nudEstoqueMinimo.Value = Convert.ToDecimal(produto.EstoqueMinimo);
                cmbCategoria.Text = produto.Categoria.Nome;

                var imagem = Produto.ObterPorId(produto.Id);
                using (MemoryStream ms = new MemoryStream(imagem.Imagem))
                {
                    picImagem.Image = Image.FromStream(ms);
                    picImagem.SizeMode = PictureBoxSizeMode.Zoom;
                }

                if (produto.Descontinuado == 1)
                {
                    chkDescontinuado.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Numero de caracteres inválido.");
            }
        }
    }
}
