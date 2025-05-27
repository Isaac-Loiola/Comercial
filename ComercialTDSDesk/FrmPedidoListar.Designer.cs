namespace ComercialTDSDesk
{
    partial class FrmPedidoListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoListar));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvListarPedidos = new ReaLTaiizor.Controls.PoisonDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarPedidos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dgvListarPedidos);
            panel1.Location = new Point(339, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 594);
            panel1.TabIndex = 0;
            // 
            // dgvListarPedidos
            // 
            dgvListarPedidos.AllowUserToAddRows = false;
            dgvListarPedidos.AllowUserToDeleteRows = false;
            dgvListarPedidos.AllowUserToResizeRows = false;
            dgvListarPedidos.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvListarPedidos.BorderStyle = BorderStyle.None;
            dgvListarPedidos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListarPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListarPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListarPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarPedidos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvListarPedidos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvListarPedidos.EnableHeadersVisualStyles = false;
            dgvListarPedidos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvListarPedidos.GridColor = Color.FromArgb(255, 255, 255);
            dgvListarPedidos.Location = new Point(3, 13);
            dgvListarPedidos.Name = "dgvListarPedidos";
            dgvListarPedidos.ReadOnly = true;
            dgvListarPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvListarPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvListarPedidos.RowHeadersVisible = false;
            dgvListarPedidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListarPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListarPedidos.Size = new Size(1021, 562);
            dgvListarPedidos.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 110;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "ID do Usuario";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Data";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Status";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 260;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Desconto";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 275;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(1105, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 30);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 2;
            // 
            // FrmPedidoListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 907);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPedidoListar";
            Text = "FrmPedidoListar";
            Load += FrmPedidoListar_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarPedidos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvListarPedidos;
        private Panel panel2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}