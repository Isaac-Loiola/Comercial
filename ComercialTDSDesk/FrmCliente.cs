using ComercialTDSClass;
using NcMaster;
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
            var clientes = ComercialTDSClass.Cliente.ObterLista();
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
                
                if(txtCep.Text != string.Empty && txtBairro.Text != string.Empty && txtCidade.Text != string.Empty && txtLogradouro.Text != string.Empty &&
                    txtUf.Text != string.Empty && cmbTipoEndereco.Text != string.Empty && txtComplemento.Text != string.Empty && txtNumero.Text != string.Empty)
                {
                    Cliente cliente = new(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, Convert.ToDateTime(txtDataNascimento.Text));
                    cliente.Inserir();
                    if(cliente.Id > 0)
                    {
                        Endereco endereco = new(cliente.Id, txtCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, cmbTipoEndereco.Text);
                        endereco.Inserir();

                        MessageBox.Show($"{cliente.Nome} cadastrado com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Adicionar endereço!");
                }
            }
            else
            {
                MessageBox.Show("Todos campos são obrigatórios para inserir!");
            }


        }

        private void tpEndereco_Click(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if(txtCep.Text.Length > 6)
            {
                WebCEP webCEP = new(txtCep.Text);
                txtLogradouro.Text = webCEP.Lagradouro;
                txtBairro.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                txtUf.Text = webCEP.UF;
            }
        }
    }
}
