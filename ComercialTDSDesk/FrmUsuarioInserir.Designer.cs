namespace ComercialTDSDesk
{
    partial class FrmUsuarioInserir
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
            button1 = new Button();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            cmbNivel = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(417, 498);
            button1.Name = "button1";
            button1.Size = new Size(208, 48);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(120, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(208, 23);
            txtNome.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(120, 191);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(208, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 2;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(207, 241);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbNivel);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(417, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 353);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 132);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // FrmUsuarioInserir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 596);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuarioInserir";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private ComboBox cmbNivel;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}