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
            pnlClienteInserir.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClienteInserir
            // 
            pnlClienteInserir.Controls.Add(panel5);
            pnlClienteInserir.Controls.Add(panel4);
            pnlClienteInserir.Controls.Add(panel3);
            pnlClienteInserir.Controls.Add(panel2);
            pnlClienteInserir.Controls.Add(panel1);
            pnlClienteInserir.Location = new Point(130, 115);
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
            btnInserir.Location = new Point(130, 537);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(149, 30);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 907);
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
    }
}