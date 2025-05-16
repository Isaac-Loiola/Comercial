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
    public partial class FrmUsuarioListar : Form
    {
        public FrmUsuarioListar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmUsuarioListar_Load(object sender, EventArgs e)
        {
            int linha = 0;
            var usuarios = Usuario.ObterLista();
            foreach(var usuario in usuarios)
            {
                dgvListarUsuario.Rows.Add();
                dgvListarUsuario.Rows[linha].Cells[0].Value = usuario.Id;
                dgvListarUsuario.Rows[linha].Cells[1].Value = usuario.Nome;
                dgvListarUsuario.Rows[linha].Cells[2].Value = usuario.Email;
                dgvListarUsuario.Rows[linha].Cells[3].Value = usuario.Senha;
                dgvListarUsuario.Rows[linha].Cells[4].Value = usuario.Nivel.Nome;
                dgvListarUsuario.Rows[linha].Cells[5].Value = usuario.Ativo == true? "sim" : "não";

                linha++;
            }
        }
    }
}
