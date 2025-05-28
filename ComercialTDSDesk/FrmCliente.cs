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
            var clientes = Cliente.ObterLista();
            int linha = 0;
            foreach (var cliente in clientes)
            {
                dgvClienteListar.Rows.Add();
                dgvClienteListar.Rows[linha].Cells[0].Value = cliente.Id;
                dgvClienteListar.Rows[linha].Cells[1].Value = cliente.Nome;
                dgvClienteListar.Rows[linha].Cells[2].Value = cliente.Telefone;
                dgvClienteListar.Rows[linha].Cells[3].Value = cliente.Cpf;
                dgvClienteListar.Rows[linha].Cells[4].Value = cliente.Email;
                dgvClienteListar.Rows[linha].Cells[5].Value = cliente.DataNascimento;
                dgvClienteListar.Rows[linha].Cells[6].Value = cliente.DataCadastro;

                linha++;
            }
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
