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
            if (Program.UsuarioLogado.Id > 0)
            {
                tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
            }
            this.Show();
        }

        private void AssociaPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlPrincipal.Size;
            form.Size = pnlPrincipal.Size;
            pnlPrincipal.Controls.Clear();
            form.MaximizeBox = true;
            form.AutoSize = true;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(form);
            form.Show();
            pnlPrincipal.Visible = true;
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            frmLogin.btnCancelar.Text = "&Voltar";
            frmLogin.ShowDialog();
            tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;

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
            AssociaPanel(new FrmUsuarioInserir());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmUsuarioListar());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmUsuarioInserir());

        }
    }
}
