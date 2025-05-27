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
                    grbIndentificacao.Enabled = false;
                    grbItens.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ID do cliente inválido!");
            }


        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 6)
            {
                var produto = Produto.ObterPorCodBar(txtIdPedido.Text);
                if (produto.Id == 0)
                {
                    produto = Produto.ObterPorId(int.Parse(txtCodBar.Text));


                }
                txtIdProd.Text = produto.Id.ToString();
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString("R$##.00");
                label4.Text = $"R$ {produto.ValorUnit * produto.ClasseDesconto}";
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new
                (
                    int.Parse(txtIdPedido.Text),
                    Produto.ObterPorId(int.Parse(txtIdProd.Text)),
                    double.Parse(txtQuantidade.Text),
                    double.Parse(txtDescontoItem.Text)
                );
            itemPedido.Inserir();

            if (itemPedido.Id > 0)
            {
                CarregarItems(int.Parse(txtIdPedido.Text));
            }
        }
        private void CarregarItems(int pedidoId)
        {
            var itens = ItemPedido.ObterListaPorPedidoId(pedidoId);
            int linha = 0;
            double descontos = 0;
            double subTotal = 0;

            dgvItensPedido.Rows.Clear();
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = $"#{linha + 1}";
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBarras;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit;
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto;
                descontos = +item.Desconto;
                double totalItem = item.ValorUnit * item.Quantidade - item.Desconto;

                dgvItensPedido.Rows[linha].Cells[6].Value = totalItem;
                subTotal += totalItem;

                linha++;
            }
            txtSubTotalItens.Text = subTotal.ToString();
            txtSubTotal.Text = subTotal.ToString();
            txtDescontoItens.Text = descontos.ToString();
            txtTotal.Text = (subTotal - descontos).ToString();
        }

        private void txtIdPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtIdPedido.Text.Length > 5)
                {
                    var pedido = Pedido.ObterPorId(int.Parse(txtIdPedido.Text));
                    if (pedido.Id > 0)
                    {
                        if (pedido.Status == "A")
                        {
                            grbIndentificacao.Enabled = false;
                            txtNomeCliente.Text = pedido.Cliente.Nome;
                            txtIdCliente.Text = pedido.Cliente.Id.ToString();

                            txtUsuario.Text = $"{pedido.Usuario.Id} - {pedido.Usuario.Nome}";
                            grbItens.Enabled = true;
                            CarregarItems(pedido.Id);
                        }
                        else if (pedido.Status == "F")
                        {
                            var resposta = MessageBox.Show("O pedido está fechado. \nDeseja Reabrir?",
                            "Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Numeros de carâcteres do indentificador incorreto!");
                }
            }
        }

        private void txtDescontoPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTotal.Text = (double.Parse(txtSubTotalItens.Text) - double.Parse(txtDescontoPedido.Text)).ToString("##.00");
            }
        }

        /// <summary>
        /// Método para tratar exeções gerais
        /// </summary>
        private void LimparControles()
        {
            txtCodBar.Clear();
            txtDescontoItem.Clear();
            txtDescontoItens.Clear();
            txtDescontoPedido.Clear();
            txtDescricao.Clear();
            txtIdPedido.Clear();
            txtIdProd.Clear();
            txtTotal.Clear();
            txtValorUnit.Clear();
            txtSubTotalItens.Clear();
            dgvItensPedido.Rows.Clear();

            grbIndentificacao.Enabled = true;
            grbItens.Enabled = false;
            txtIdCliente.Clear();
            txtNomeCliente.Clear();
        }
        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = Pedido.ObterPorId(int.Parse(txtIdPedido.Text));
            pedido.Desconto = Convert.ToDouble(txtDescontoPedido.Text);
            pedido.Status = "F";
            if (pedido.Atualizar())
            {
                MessageBox.Show($"Pedido {pedido.Id} foi fechado com sucesso! \n");
                LimparControles();
            }
        }

        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
