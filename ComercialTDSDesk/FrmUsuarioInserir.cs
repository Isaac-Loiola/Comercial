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
    public partial class FrmUsuarioInserir : Form
    {
        public FrmUsuarioInserir()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text, Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)));
            if (usuario.Nome != string.Empty && usuario.Email != string.Empty && usuario.Senha != string.Empty && cmbNivel.SelectedValue != string.Empty)
            {
                usuario.Inserir();
                MessageBox.Show($"{usuario.Nome} cadastrado com sucesso!");
                txtSenha.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
            }
            else
            {
                MessageBox.Show("Os campos devem ser obrigatórios");
            }
        }

        private void chkExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExibirSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
