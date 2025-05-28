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
    public partial class FrmFornecedorInserir : Form
    {
        public FrmFornecedorInserir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(txtRazaoSocial.Text, txtFantasia.Text, txtCnpj.Text, txtContato.Text, txtTelefone.Text, txtEmail.Text);
            fornecedor.Inserir();
            if(fornecedor.Id > 0)
            {
                MessageBox.Show("Fornedor cadastrato com sucesso!");
            }
            else
            {
                MessageBox.Show("Fornecedor não cadastrado!");
            }
        }
    }
}
