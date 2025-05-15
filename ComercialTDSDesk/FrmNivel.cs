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
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                if (txtNome.Text != string.Empty && txtSigla.Text != string.Empty)
                {
                    Nivel nivel = new(txtNome.Text, txtSigla.Text);
                    nivel.Inserir();
                    if (nivel.Id > 0)
                    {
                        MessageBox.Show("Nivel adicionado com sucesso!");
                        btnGravar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Nivel não cadastrado!");
                    }
                }
            }
            else
            {
                Nivel nivel = new(int.Parse(txtId.Text), txtNome.Text, txtSigla.Text);
                if (nivel.Atualizar())
                {
                    MessageBox.Show("Nível atualizado com sucesso!");
                    btnGravar.Enabled = false;
                }
            }
            CarregaGrid();
            LimpaControles();

        }

        private void LimpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            txtSigla.Clear();
        }

        private void CarregaGrid()
        {
            var niveis = Nivel.ObterLista();
            int linha = 0;
            dgvNiveis.Rows.Clear();
            foreach (var nivel in niveis)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[linha].Cells[0].Value = nivel.Id;
                dgvNiveis.Rows[linha].Cells[1].Value = nivel.Nome;
                dgvNiveis.Rows[linha].Cells[2].Value = nivel.Sigla;

                linha++;
            }
        }

        private void FrmNivel_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNiveis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Recuperando o indice da linha do grid.
            int linha = dgvNiveis.CurrentRow.Index;
            // Recuperando o id do nivel na coluna, oculta, ID (0)
            int id = Convert.ToInt32(dgvNiveis.Rows[linha].Cells[0].Value);

            var nivel = Nivel.ObterPorId(id);

            // atribuindo os dados do nivel, ao textbox.
            txtId.Text = nivel.Id.ToString();
            txtNome.Text = nivel.Nome;
            txtSigla.Text = nivel.Sigla;

            txtNome.ReadOnly = true;
            txtSigla.ReadOnly = true;

            btnEditar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtSigla.ReadOnly = false;
            btnEditar.Enabled = false;
            btnGravar.Enabled = true;

        }
    }
}
