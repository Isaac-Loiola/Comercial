namespace ComercialTDSDesk
{
    partial class FrmLogin
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
            btnEntrar = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            chkExibirSenha = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(260, 310);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(116, 31);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(468, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(260, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(324, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(260, 224);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(324, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // chkExibirSenha
            // 
            chkExibirSenha.AutoSize = true;
            chkExibirSenha.Checked = true;
            chkExibirSenha.CheckState = CheckState.Checked;
            chkExibirSenha.Location = new Point(564, 229);
            chkExibirSenha.Name = "chkExibirSenha";
            chkExibirSenha.Size = new Size(15, 14);
            chkExibirSenha.TabIndex = 4;
            chkExibirSenha.UseVisualStyleBackColor = true;
            chkExibirSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 94);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 5;
            label1.Text = "Acesso ao sistema";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 45);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 6;
            label2.Text = "Comercial TDS System";
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkExibirSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        public Button btnCancelar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private CheckBox chkExibirSenha;
        private Label label1;
        private Label label2;
    }
}