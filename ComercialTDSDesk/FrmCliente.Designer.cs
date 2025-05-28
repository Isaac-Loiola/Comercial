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
            txtId = new TextBox();
            tcCadastroCLiente = new TabControl();
            tpInserir = new TabPage();
            tpEndereco = new TabPage();
            panel14 = new Panel();
            cmbTipoEndereco = new ComboBox();
            panel11 = new Panel();
            txtComplemento = new TextBox();
            panel10 = new Panel();
            txtUf = new TextBox();
            panel12 = new Panel();
            txtCidade = new TextBox();
            panel13 = new Panel();
            txtBairro = new TextBox();
            panel8 = new Panel();
            txtLogradouro = new TextBox();
            panel9 = new Panel();
            txtNumero = new TextBox();
            panel7 = new Panel();
            txtCep = new TextBox();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClienteListar).BeginInit();
            tcCadastroCLiente.SuspendLayout();
            tpInserir.SuspendLayout();
            tpEndereco.SuspendLayout();
            panel14.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(txtDataNascimento);
            panel5.Location = new Point(157, 536);
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
            panel4.Location = new Point(157, 188);
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
            panel3.Location = new Point(157, 421);
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
            panel2.Location = new Point(157, 309);
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
            panel1.Location = new Point(157, 64);
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
            btnInserir.Location = new Point(212, 751);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(149, 40);
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
            // txtId
            // 
            txtId.Location = new Point(245, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(37, 23);
            txtId.TabIndex = 3;
            txtId.Visible = false;
            // 
            // tcCadastroCLiente
            // 
            tcCadastroCLiente.Controls.Add(tpInserir);
            tcCadastroCLiente.Controls.Add(tpEndereco);
            tcCadastroCLiente.Location = new Point(22, 124);
            tcCadastroCLiente.Name = "tcCadastroCLiente";
            tcCadastroCLiente.SelectedIndex = 0;
            tcCadastroCLiente.Size = new Size(555, 621);
            tcCadastroCLiente.TabIndex = 4;
            // 
            // tpInserir
            // 
            tpInserir.Controls.Add(panel1);
            tpInserir.Controls.Add(txtId);
            tpInserir.Controls.Add(panel5);
            tpInserir.Controls.Add(panel4);
            tpInserir.Controls.Add(panel3);
            tpInserir.Controls.Add(panel2);
            tpInserir.Location = new Point(4, 24);
            tpInserir.Name = "tpInserir";
            tpInserir.Padding = new Padding(3);
            tpInserir.Size = new Size(547, 593);
            tpInserir.TabIndex = 0;
            tpInserir.Text = "Cliente";
            tpInserir.UseVisualStyleBackColor = true;
            // 
            // tpEndereco
            // 
            tpEndereco.Controls.Add(panel14);
            tpEndereco.Controls.Add(panel11);
            tpEndereco.Controls.Add(panel10);
            tpEndereco.Controls.Add(panel12);
            tpEndereco.Controls.Add(panel13);
            tpEndereco.Controls.Add(panel8);
            tpEndereco.Controls.Add(panel9);
            tpEndereco.Controls.Add(panel7);
            tpEndereco.Location = new Point(4, 24);
            tpEndereco.Name = "tpEndereco";
            tpEndereco.Padding = new Padding(3);
            tpEndereco.Size = new Size(547, 593);
            tpEndereco.TabIndex = 1;
            tpEndereco.Text = "Endereco";
            tpEndereco.UseVisualStyleBackColor = true;
            tpEndereco.Click += tpEndereco_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(cmbTipoEndereco);
            panel14.Location = new Point(211, 453);
            panel14.Name = "panel14";
            panel14.Size = new Size(118, 30);
            panel14.TabIndex = 1;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "RES", "COM", "ENT" });
            cmbTipoEndereco.Location = new Point(8, 4);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(103, 23);
            cmbTipoEndereco.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(txtComplemento);
            panel11.Location = new Point(290, 224);
            panel11.Name = "panel11";
            panel11.Size = new Size(233, 30);
            panel11.TabIndex = 1;
            // 
            // txtComplemento
            // 
            txtComplemento.BorderStyle = BorderStyle.None;
            txtComplemento.Font = new Font("Segoe UI", 11F);
            txtComplemento.Location = new Point(3, 5);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(225, 20);
            txtComplemento.TabIndex = 0;
            txtComplemento.TextAlign = HorizontalAlignment.Center;
            // 
            // panel10
            // 
            panel10.Controls.Add(txtUf);
            panel10.Location = new Point(211, 384);
            panel10.Name = "panel10";
            panel10.Size = new Size(118, 30);
            panel10.TabIndex = 1;
            // 
            // txtUf
            // 
            txtUf.BorderStyle = BorderStyle.None;
            txtUf.Font = new Font("Segoe UI", 11F);
            txtUf.Location = new Point(8, 5);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(103, 20);
            txtUf.TabIndex = 0;
            txtUf.TextAlign = HorizontalAlignment.Center;
            // 
            // panel12
            // 
            panel12.Controls.Add(txtCidade);
            panel12.Location = new Point(144, 318);
            panel12.Name = "panel12";
            panel12.Size = new Size(233, 30);
            panel12.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Font = new Font("Segoe UI", 11F);
            txtCidade.Location = new Point(3, 5);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(225, 20);
            txtCidade.TabIndex = 0;
            txtCidade.TextAlign = HorizontalAlignment.Center;
            // 
            // panel13
            // 
            panel13.Controls.Add(txtBairro);
            panel13.Location = new Point(17, 224);
            panel13.Name = "panel13";
            panel13.Size = new Size(233, 30);
            panel13.TabIndex = 1;
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.None;
            txtBairro.Font = new Font("Segoe UI", 11F);
            txtBairro.Location = new Point(3, 5);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(225, 20);
            txtBairro.TabIndex = 0;
            txtBairro.TextAlign = HorizontalAlignment.Center;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtLogradouro);
            panel8.Location = new Point(17, 126);
            panel8.Name = "panel8";
            panel8.Size = new Size(233, 30);
            panel8.TabIndex = 1;
            // 
            // txtLogradouro
            // 
            txtLogradouro.BorderStyle = BorderStyle.None;
            txtLogradouro.Font = new Font("Segoe UI", 11F);
            txtLogradouro.Location = new Point(3, 5);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(225, 20);
            txtLogradouro.TabIndex = 0;
            txtLogradouro.TextAlign = HorizontalAlignment.Center;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtNumero);
            panel9.Location = new Point(290, 126);
            panel9.Name = "panel9";
            panel9.Size = new Size(233, 30);
            panel9.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.Font = new Font("Segoe UI", 11F);
            txtNumero.Location = new Point(3, 5);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(225, 20);
            txtNumero.TabIndex = 0;
            txtNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtCep);
            panel7.Location = new Point(144, 38);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 30);
            panel7.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.BorderStyle = BorderStyle.None;
            txtCep.Font = new Font("Segoe UI", 11F);
            txtCep.Location = new Point(3, 5);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(225, 20);
            txtCep.TabIndex = 0;
            txtCep.TextAlign = HorizontalAlignment.Center;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 907);
            Controls.Add(tcCadastroCLiente);
            Controls.Add(panel6);
            Controls.Add(btnInserir);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
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
            tcCadastroCLiente.ResumeLayout(false);
            tpInserir.ResumeLayout(false);
            tpInserir.PerformLayout();
            tpEndereco.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox txtId;
        private TabControl tcCadastroCLiente;
        private TabPage tpInserir;
        private TabPage tpEndereco;
        private Panel panel13;
        private TextBox txtBairro;
        private Panel panel9;
        private TextBox txtNumero;
        private Panel panel7;
        private TextBox txtCep;
        private Panel panel12;
        private TextBox txtCidade;
        private Panel panel11;
        private TextBox txtComplemento;
        private Panel panel8;
        private TextBox txtLogradouro;
        private Panel panel10;
        private TextBox txtUf;
        private Panel panel14;
        private ComboBox cmbTipoEndereco;
    }
}