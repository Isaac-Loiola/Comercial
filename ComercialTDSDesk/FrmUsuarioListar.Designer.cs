namespace ComercialTDSDesk
{
    partial class FrmUsuarioListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioListar));
            dgvListarUsuario = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnSenha = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtBuscarUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListarUsuario).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvListarUsuario
            // 
            dgvListarUsuario.AllowUserToAddRows = false;
            dgvListarUsuario.AllowUserToDeleteRows = false;
            dgvListarUsuario.BackgroundColor = Color.White;
            dgvListarUsuario.BorderStyle = BorderStyle.None;
            dgvListarUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarUsuario.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnSenha, clnNivel, clnAtivo });
            dgvListarUsuario.Location = new Point(16, 23);
            dgvListarUsuario.Name = "dgvListarUsuario";
            dgvListarUsuario.ReadOnly = true;
            dgvListarUsuario.RowHeadersVisible = false;
            dgvListarUsuario.Size = new Size(753, 403);
            dgvListarUsuario.TabIndex = 2;
            dgvListarUsuario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "Id";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Visible = false;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 250;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 250;
            // 
            // clnSenha
            // 
            clnSenha.HeaderText = "Senha";
            clnSenha.Name = "clnSenha";
            clnSenha.ReadOnly = true;
            clnSenha.Visible = false;
            clnSenha.Width = 200;
            // 
            // clnNivel
            // 
            clnNivel.HeaderText = "Nivel";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 150;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dgvListarUsuario);
            panel1.Location = new Point(290, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 451);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(856, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.BorderStyle = BorderStyle.None;
            txtBuscarUsuario.Location = new Point(865, 52);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Buscar";
            txtBuscarUsuario.Size = new Size(203, 16);
            txtBuscarUsuario.TabIndex = 5;
            // 
            // FrmUsuarioListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1248, 573);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "FrmUsuarioListar";
            Text = "FrmUsuarioListar";
            Load += FrmUsuarioListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListarUsuario).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListarUsuario;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnSenha;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewTextBoxColumn clnAtivo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtBuscarUsuario;
    }
}