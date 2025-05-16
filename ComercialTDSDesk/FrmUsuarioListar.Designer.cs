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
            dgvListarUsuario = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnSenha = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListarUsuario).BeginInit();
            SuspendLayout();
            // 
            // dgvListarUsuario
            // 
            dgvListarUsuario.AllowUserToAddRows = false;
            dgvListarUsuario.AllowUserToDeleteRows = false;
            dgvListarUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarUsuario.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnSenha, clnNivel, clnAtivo });
            dgvListarUsuario.Location = new Point(284, 81);
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
            // FrmUsuarioListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 573);
            Controls.Add(dgvListarUsuario);
            Name = "FrmUsuarioListar";
            Text = "FrmUsuarioListar";
            Load += FrmUsuarioListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListarUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListarUsuario;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnSenha;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewTextBoxColumn clnAtivo;
    }
}