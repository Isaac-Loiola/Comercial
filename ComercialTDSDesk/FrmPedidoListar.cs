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
    public partial class FrmPedidoListar : Form
    {
        public FrmPedidoListar()
        {
            InitializeComponent();
        }

        private void FrmPedidoListar_Load(object sender, EventArgs e)
        {
            var pedidos = Pedido.ObterLista();
            int linha = 0;
            foreach(var pedido in pedidos)
            {
                dgvListarPedidos.Rows.Add();
                dgvListarPedidos.Rows[linha].Cells[0].Value = pedido.Id;
                dgvListarPedidos.Rows[linha].Cells[1].Value = pedido.Usuario.Id;
                dgvListarPedidos.Rows[linha].Cells[0].Value = pedido.Data;
                dgvListarPedidos.Rows[linha].Cells[0].Value = pedido.Status;
                dgvListarPedidos.Rows[linha].Cells[0].Value = pedido.Desconto;

                linha++;
            }
        }
    }
}
