namespace ComercialTDSDesk
{
    partial class FrmCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlClienteInserir = new Panel();
            panel5 = new Panel();
            txtDataNascimento = new MaskedTextBox();
            panel4 = new Panel();
            txtEmail = new TextBox();
            panel3 = new Panel();
            txtTelefone = new MaskedTextBox();
            panel2 = new Panel();
            txtCpf = new MaskedTextBox();
            panel1 = new Panel();
            txtNome = new TextBox();
            btnInserir = new Button();
            panel6 = new Panel();
            dgvClienteListar = new ReaLTaiizor.Controls.PoisonDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pnlClienteInserir.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClienteListar).BeginInit();
            SuspendLayout();
            // 
            // pnlClienteInserir
            // 
            pnlClienteInserir.Controls.Add(panel5);
            pnlClienteInserir.Controls.Add(panel4);
            pnlClienteInserir.Controls.Add(panel3);
            pnlClienteInserir.Controls.Add(panel2);
            pnlClienteInserir.Controls.Add(panel1);
            pnlClienteInserir.Location = new Point(86, 205);
            pnlClienteInserir.Name = "pnlClienteInserir";
            pnlClienteInserir.Size = new Size(344, 416);
            pnlClienteInserir.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtDataNascimento);
            panel5.Location = new Point(59, 361);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 30);
            panel5.TabIndex = 2;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.BorderStyle = BorderStyle.None;
            txtDataNascimento.Font = new Font("Segoe UI", 11F);
            txtDataNascimento.Location = new Point(63, 6);
            txtDataNascimento.Mask = "0000-00-00";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(115, 20);
            txtDataNascimento.TabIndex = 1;
            txtDataNascimento.TextAlign = HorizontalAlignment.Center;
            txtDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // panel4
            // 
            panel4.Controls.Add(txtEmail);
            panel4.Location = new Point(59, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 30);
            panel4.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(3, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 20);
            txtEmail.TabIndex = 0;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTelefone);
            panel3.Location = new Point(59, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 30);
            panel3.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 11F);
            txtTelefone.Location = new Point(63, 1);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(115, 27);
            txtTelefone.TabIndex = 3;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCpf);
            panel2.Location = new Point(59, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 30);
            panel2.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 11F);
            txtCpf.Location = new Point(3, 2);
            txtCpf.Mask = "000-000-000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(225, 27);
            txtCpf.TabIndex = 0;
            txtCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(59, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 30);
            panel1.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(3, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(225, 20);
            txtNome.TabIndex = 0;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // btnInserir
            // 
            btnInserir.ForeColor = SystemColors.ControlText;
            btnInserir.Location = new Point(174, 627);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(149, 30);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(dgvClienteListar);
            panel6.Location = new Point(603, 97);
            panel6.Name = "panel6";
            panel6.Size = new Size(1066, 764);
            panel6.TabIndex = 2;
            // 
            // dgvClienteListar
            // 
            dgvClienteListar.AllowUserToAddRows = false;
            dgvClienteListar.AllowUserToDeleteRows = false;
            dgvClienteListar.AllowUserToResizeRows = false;
            dgvClienteListar.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvClienteListar.BorderStyle = BorderStyle.None;
            dgvClienteListar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClienteListar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClienteListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClienteListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienteListar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClienteListar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClienteListar.EnableHeadersVisualStyles = false;
            dgvClienteListar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvClienteListar.GridColor = Color.FromArgb(255, 255, 255);
            dgvClienteListar.Location = new Point(15, 15);
            dgvClienteListar.Name = "dgvClienteListar";
            dgvClienteListar.ReadOnly = true;
            dgvClienteListar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClienteListar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClienteListar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClienteListar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClienteListar.Size = new Size(1037, 732);
            dgvClienteListar.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "CPF";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Telefone";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.Frozen = true;
            Column6.HeaderText = "Data de Nascimento";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.Frozen = true;
            Column7.HeaderText = "Data de  Cadastro";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 170;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 907);
            Controls.Add(panel6);
            Controls.Add(btnInserir);
            Controls.Add(pnlClienteInserir);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            pnlClienteInserir.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClienteListar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClienteInserir;
        private Panel panel1;
        private TextBox txtNome;
        private Panel panel4;
        private TextBox txtEmail;
        private Panel panel3;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox txtDataNascimento;
        private Panel panel5;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCpf;
        private Button btnInserir;
        private Panel panel6;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvClienteListar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}