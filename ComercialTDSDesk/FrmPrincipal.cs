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
            FrmNivel frmNIvel = new();
            frmNIvel.TopLevel = false;
            frmNIvel.FormBorderStyle = FormBorderStyle.None;
            frmNIvel.Size = pnlPrincipal.Size;
            frmNIvel.Size = pnlPrincipal.Size;
            pnlPrincipal.Controls.Clear();
            frmNIvel.MaximizeBox = true;
            frmNIvel.AutoSize = true;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frmNIvel);
            frmNIvel.Show();
            pnlPrincipal.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarioInserir frmUsuarioInserir = new();
            frmUsuarioInserir.TopLevel = false;
            frmUsuarioInserir.FormBorderStyle = FormBorderStyle.None;
            frmUsuarioInserir.Size = pnlPrincipal.Size;
            frmUsuarioInserir.Size = pnlPrincipal.Size;
            pnlPrincipal.Controls.Clear();
            frmUsuarioInserir.MaximizeBox = true;
            frmUsuarioInserir.AutoSize = true;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frmUsuarioInserir);
            frmUsuarioInserir.Show();
            pnlPrincipal.Visible = true;


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
