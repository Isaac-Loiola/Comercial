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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtNome.Text != string.Empty && txtCpf.Text != string.Empty && txtTelefone.Text != string.Empty && txtEmail.Text != string.Empty && txtDataNascimento.Text != string.Empty)
            {
                Cliente cliente = new(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, Convert.ToDateTime(txtDataNascimento.Text));
                cliente.Inserir();
                if(cliente.Id > 0)
                {
                    MessageBox.Show($"{cliente.Nome} inserido com sucesso!");
                }
                else
                {
                    MessageBox.Show($"Falha ao inserir {cliente.Nome}");
                }
            }
            else
            {
                MessageBox.Show("Todos campos são obrigatórios para inserir!");
            }
            
            
        }
    }
}
