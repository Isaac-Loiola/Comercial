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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = $"{Program.UsuarioLogado.Id} - {Program.UsuarioLogado.Nome}";
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length > 4)
            {
                var cliente = Cliente.ObterPorId(Convert.ToInt32(txtIdCliente.Text));
                if (cliente.Id > 0)
                {
                    txtNomeCliente.Text = cliente.Nome;
                }
                else
                {
                    MessageBox.Show("ID do usuario inválido!");
                }
            }
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text.Length > 5)
            {
                Pedido pedido = new(Program.UsuarioLogado, Cliente.ObterPorId(int.Parse(txtIdCliente.Text)));
                pedido.Inserir();
                if (pedido.Id > 0)
                {
                    //MessageBox.Show($"Pedido ")
                    txtIdPedido.Text = pedido.Id.ToString();
                    //grbIndentificacaok
                }
            }
            else
            {
                MessageBox.Show("ID do cliente inválido!");
            }


        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            var produto = Produto.ObterPorBar(txtIdPedido. Text);
        }
    }
}
