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
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(244, 201);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(82, 201);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(163, 201);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 103);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(237, 23);
            txtNome.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            txtId.Visible = false;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(82, 152);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(100, 23);
            txtSigla.TabIndex = 5;
            // 
            // dgvNiveis
            // 
            dgvNiveis.AllowUserToAddRows = false;
            dgvNiveis.AllowUserToDeleteRows = false;
            dgvNiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNiveis.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnSigla });
            dgvNiveis.Location = new Point(421, 72);
            dgvNiveis.Name = "dgvNiveis";
            dgvNiveis.ReadOnly = true;
            dgvNiveis.RowHeadersVisible = false;
            dgvNiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNiveis.Size = new Size(280, 180);
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
            clnNome.Width = 180;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            clnSigla.Resizable = DataGridViewTriState.False;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 106);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 155);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Sigla";
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 388);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvNiveis);
            Controls.Add(txtSigla);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNivel";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmNivel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
    }
}