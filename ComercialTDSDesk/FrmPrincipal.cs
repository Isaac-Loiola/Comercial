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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            this.Hide();
            frmLogin.ShowDialog();
            this.Show();
        }

        private void AssociaPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlCentral.Size;
            form.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            form.MaximizeBox = true;
            form.AutoSize = true;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(form);
            form.Show();
            pnlCentral.Visible = true;
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void níveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AssociaPanel(new FrmNivel());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //AssociaPanel(new FrmUsuarioListar());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //AssociaPanel(new FrmUsuarioInserir());

        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AssociaPanel(new FrmProduto());
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AssociaPanel(new FrmProdutoListar());
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool menuEspandidoProdutos = false;

        private void transicaoMenu_Tick(object sender, EventArgs e)
        {
            if (menuEspandidoProdutos == false)
            {
                flpMenuLateralProdutos.Height += 15;
                if (flpMenuLateralProdutos.Height >= 348)
                {
                    transicaoMenuProdutos.Stop();
                    menuEspandidoProdutos = true;
                }

            }
            else
            {
                flpMenuLateralProdutos.Height -= 15;
                if (flpMenuLateralProdutos.Height <= 53)
                {
                    transicaoMenuProdutos.Stop();
                    menuEspandidoProdutos = false;
                }
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            transicaoMenuProdutos.Start();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            transicaoMenuCaixa.Start();
        }


        public bool menuEspandidoFornecedores = false;
        private void transicaoMenuFornecedores_Tick(object sender, EventArgs e)
        {
            if (menuEspandidoFornecedores == false)
            {
                flpMenuLateralFornecedores.Height += 15;
                if (flpMenuLateralFornecedores.Height >= 166)
                {
                    transicaoMenuFornecedores.Stop();
                    menuEspandidoFornecedores = true;
                }
            }
            else
            {
                flpMenuLateralFornecedores.Height -= 15;
                if (flpMenuLateralFornecedores.Height <= 53)
                {
                    transicaoMenuFornecedores.Stop();
                    menuEspandidoFornecedores = false;
                }
            }
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            transicaoMenuFornecedores.Start();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            transicaoMenuPedidos.Start();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

        }

        bool menuEspandidoPedidos = false;
        private void transicaoMenuPedidos_Tick(object sender, EventArgs e)
        {
            if (menuEspandidoPedidos == false)
            {
                flpMenuLateralPedidos.Height += 15;
                if (flpMenuLateralPedidos.Height >= 202)
                {
                    transicaoMenuPedidos.Stop();
                    menuEspandidoPedidos = true;
                }
            }
            else
            {
                flpMenuLateralPedidos.Height -= 15;
                if (flpMenuLateralPedidos.Height <= 53)
                {
                    transicaoMenuPedidos.Stop();
                    menuEspandidoPedidos = false;
                }
            }
        }

        bool menuEspandidoCaixa = false;
        private void transicaoMenuCaixa_Tick(object sender, EventArgs e)
        {
            if (menuEspandidoCaixa == false)
            {
                flpMenuLateralCaixa.Height += 15;
                if (flpMenuLateralCaixa.Height >= 290)
                {
                    transicaoMenuCaixa.Stop();
                    menuEspandidoCaixa = true;
                }
            }
            else
            {
                flpMenuLateralCaixa.Height -= 15;
                if (flpMenuLateralCaixa.Height <= 53)
                {
                    transicaoMenuCaixa.Stop();
                    menuEspandidoCaixa = false;
                }
            }
        }

        bool menuEspandidoVendas = false;
        private void transicaoMenuVendas_Tick(object sender, EventArgs e)
        {
            if (menuEspandidoVendas == false)
            {
                flpMenulateralVendas.Height += 15;
                if (flpMenulateralVendas.Height >= 160)
                {
                    transicaoMenuVendas.Stop();
                    menuEspandidoVendas = true;
                }
            }
            else
            {
                flpMenulateralVendas.Height -= 15;
                if (flpMenulateralVendas.Height <= 53)
                {
                    transicaoMenuVendas.Stop();
                    menuEspandidoVendas = false;
                }
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            transicaoMenuVendas.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transicaoMenuUsuarios.Start();
        }

        bool menuEspandidoUsuarios = false;
        private void transicaoMenuUsuarios_Tick(object sender, EventArgs e)
        {
            if (menuEspandidoUsuarios == false)
            {
                flpMenuLateralUsuario.Height += 15;
                if (flpMenuLateralUsuario.Height >= 214)
                {
                    transicaoMenuUsuarios.Stop();
                    menuEspandidoUsuarios = true;
                }
            }
            else
            {
                flpMenuLateralUsuario.Height -= 15;
                if (flpMenuLateralUsuario.Height <= 53)
                {
                    transicaoMenuUsuarios.Stop();
                    menuEspandidoUsuarios = false;
                }
            }
        }

        private void pnlPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            transicaoMenuUsuarios.Start();
        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmUsuarioInserir());
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmUsuarioListar());
        }

        private void btnIncluirProdutos_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmProduto());
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmProdutoListar());
        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnNovoPedidos_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmPedido());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmPedidoListar());
        }
    }
}
