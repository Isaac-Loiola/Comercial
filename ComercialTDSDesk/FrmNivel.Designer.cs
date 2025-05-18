namespace ComercialTDSDesk
{
    partial class FrmNivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel));
            btnCancelar = new Button();
            btnGravar = new Button();
            btnEditar = new Button();
            txtNome = new TextBox();
            txtId = new TextBox();
            txtSigla = new TextBox();
            dgvNiveis = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            pnlLista = new Panel();
            pnlAdicionarNivel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).BeginInit();
            pnlLista.SuspendLayout();
            pnlAdicionarNivel.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(486, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 50);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.Transparent;
            btnGravar.BackgroundImage = (Image)resources.GetObject("btnGravar.BackgroundImage");
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.ForeColor = Color.White;
            btnGravar.Location = new Point(196, 375);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(102, 50);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(339, 375);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 50);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(237, 23);
            txtNome.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(265, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(50, 23);
            txtId.TabIndex = 4;
            txtId.Visible = false;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(78, 134);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(100, 23);
            txtSigla.TabIndex = 5;
            // 
            // dgvNiveis
            // 
            dgvNiveis.AllowUserToAddRows = false;
            dgvNiveis.AllowUserToDeleteRows = false;
            dgvNiveis.BackgroundColor = Color.White;
            dgvNiveis.BorderStyle = BorderStyle.None;
            dgvNiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNiveis.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnSigla });
            dgvNiveis.Location = new Point(14, 16);
            dgvNiveis.Name = "dgvNiveis";
            dgvNiveis.ReadOnly = true;
            dgvNiveis.RowHeadersVisible = false;
            dgvNiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNiveis.Size = new Size(433, 323);
            dgvNiveis.TabIndex = 6;
            dgvNiveis.CellDoubleClick += dgvNiveis_CellDoubleClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Resizable = DataGridViewTriState.False;
            clnId.Visible = false;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Resizable = DataGridViewTriState.False;
            clnNome.Width = 250;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            clnSigla.Resizable = DataGridViewTriState.False;
            clnSigla.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 116);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Sigla";
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.Transparent;
            pnlLista.BackgroundImage = (Image)resources.GetObject("pnlLista.BackgroundImage");
            pnlLista.Controls.Add(dgvNiveis);
            pnlLista.Location = new Point(673, 123);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(456, 353);
            pnlLista.TabIndex = 9;
            // 
            // pnlAdicionarNivel
            // 
            pnlAdicionarNivel.BackColor = Color.Transparent;
            pnlAdicionarNivel.BackgroundImage = (Image)resources.GetObject("pnlAdicionarNivel.BackgroundImage");
            pnlAdicionarNivel.Controls.Add(label2);
            pnlAdicionarNivel.Controls.Add(label1);
            pnlAdicionarNivel.Controls.Add(txtSigla);
            pnlAdicionarNivel.Controls.Add(txtId);
            pnlAdicionarNivel.Controls.Add(txtNome);
            pnlAdicionarNivel.Location = new Point(196, 180);
            pnlAdicionarNivel.Name = "pnlAdicionarNivel";
            pnlAdicionarNivel.Size = new Size(392, 188);
            pnlAdicionarNivel.TabIndex = 10;
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1248, 596);
            ControlBox = false;
            Controls.Add(pnlAdicionarNivel);
            Controls.Add(pnlLista);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNivel";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmNivel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).EndInit();
            pnlLista.ResumeLayout(false);
            pnlAdicionarNivel.ResumeLayout(false);
            pnlAdicionarNivel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private Button btnEditar;
        private TextBox txtNome;
        private TextBox txtId;
        private TextBox txtSigla;
        private DataGridView dgvNiveis;
        private Label label1;
        private Label label2;
        private Panel pnlLista;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
        private Panel pnlAdicionarNivel;
    }
}