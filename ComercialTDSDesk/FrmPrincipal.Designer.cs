namespace ComercialTDSDesk
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            statusStrip1 = new StatusStrip();
            tsslUsuarioLogado = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            trocarDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            fToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem2 = new ToolStripMenuItem();
            listarToolStripMenuItem2 = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            níveisToolStripMenuItem = new ToolStripMenuItem();
            operaçãoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem3 = new ToolStripMenuItem();
            movimentoToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem1 = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            emitirNotaToolStripMenuItem = new ToolStripMenuItem();
            configuraçãoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslUsuarioLogado, toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // tsslUsuarioLogado
            // 
            tsslUsuarioLogado.Name = "tsslUsuarioLogado";
            tsslUsuarioLogado.Size = new Size(12, 17);
            tsslUsuarioLogado.Text = "-";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { trocarDeUsuárioToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // trocarDeUsuárioToolStripMenuItem
            // 
            trocarDeUsuárioToolStripMenuItem.Name = "trocarDeUsuárioToolStripMenuItem";
            trocarDeUsuárioToolStripMenuItem.Size = new Size(166, 22);
            trocarDeUsuárioToolStripMenuItem.Text = "Trocar de Usuário";
            trocarDeUsuárioToolStripMenuItem.Click += trocarDeUsuárioToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, operaçãoToolStripMenuItem, movimentoToolStripMenuItem, configuraçãoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, produtoToolStripMenuItem, fToolStripMenuItem, categoriasToolStripMenuItem, usuariosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(145, 22);
            clienteToolStripMenuItem.Text = "&Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem, listarToolStripMenuItem, fornecedorToolStripMenuItem, categoriaToolStripMenuItem, estoqueToolStripMenuItem });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(145, 22);
            produtoToolStripMenuItem.Text = "&Produtos";
            // 
            // incluirToolStripMenuItem
            // 
            incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            incluirToolStripMenuItem.Size = new Size(134, 22);
            incluirToolStripMenuItem.Text = "&Incluir";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(134, 22);
            listarToolStripMenuItem.Text = "&Listar";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(134, 22);
            fornecedorToolStripMenuItem.Text = "&Fornecedor";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(134, 22);
            categoriaToolStripMenuItem.Text = "&Categoria";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(134, 22);
            estoqueToolStripMenuItem.Text = "&Estoque";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem2, listarToolStripMenuItem2 });
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(145, 22);
            fToolStripMenuItem.Text = "&Fornecedores";
            // 
            // incluirToolStripMenuItem2
            // 
            incluirToolStripMenuItem2.Name = "incluirToolStripMenuItem2";
            incluirToolStripMenuItem2.Size = new Size(107, 22);
            incluirToolStripMenuItem2.Text = "&Incluir";
            // 
            // listarToolStripMenuItem2
            // 
            listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            listarToolStripMenuItem2.Size = new Size(107, 22);
            listarToolStripMenuItem2.Text = "&Listar";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(145, 22);
            categoriasToolStripMenuItem.Text = "&Categorias";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem1, listarToolStripMenuItem1, níveisToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(145, 22);
            usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // incluirToolStripMenuItem1
            // 
            incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
            incluirToolStripMenuItem1.Size = new Size(107, 22);
            incluirToolStripMenuItem1.Text = "&Incluir";
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(107, 22);
            listarToolStripMenuItem1.Text = "&Listar";
            // 
            // níveisToolStripMenuItem
            // 
            níveisToolStripMenuItem.Name = "níveisToolStripMenuItem";
            níveisToolStripMenuItem.Size = new Size(107, 22);
            níveisToolStripMenuItem.Text = "&Níveis";
            níveisToolStripMenuItem.Click += níveisToolStripMenuItem_Click;
            // 
            // operaçãoToolStripMenuItem
            // 
            operaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem });
            operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            operaçãoToolStripMenuItem.Size = new Size(70, 20);
            operaçãoToolStripMenuItem.Text = "&Operação";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, consultarToolStripMenuItem, listarToolStripMenuItem3 });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(116, 22);
            pedidosToolStripMenuItem.Text = "&Pedidos";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(125, 22);
            novoToolStripMenuItem.Text = "&Novo";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "&Consultar";
            // 
            // listarToolStripMenuItem3
            // 
            listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            listarToolStripMenuItem3.Size = new Size(125, 22);
            listarToolStripMenuItem3.Text = "&Listar";
            // 
            // movimentoToolStripMenuItem
            // 
            movimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaToolStripMenuItem, pedidosToolStripMenuItem1, vendasToolStripMenuItem });
            movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            movimentoToolStripMenuItem.Size = new Size(81, 20);
            movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, fecharToolStripMenuItem, toolStripMenuItem2, relatórioToolStripMenuItem });
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(120, 22);
            caixaToolStripMenuItem.Text = "Caixa";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(125, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(125, 22);
            fecharToolStripMenuItem.Text = "&Terminal";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(125, 22);
            toolStripMenuItem2.Text = "&Consultar";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(125, 22);
            relatórioToolStripMenuItem.Text = "&Relatório";
            // 
            // pedidosToolStripMenuItem1
            // 
            pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            pedidosToolStripMenuItem1.Size = new Size(120, 22);
            pedidosToolStripMenuItem1.Text = "&Terminal";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem1, emitirNotaToolStripMenuItem });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(120, 22);
            vendasToolStripMenuItem.Text = "&Vendas";
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(134, 22);
            consultarToolStripMenuItem1.Text = "&Consultar";
            // 
            // emitirNotaToolStripMenuItem
            // 
            emitirNotaToolStripMenuItem.Name = "emitirNotaToolStripMenuItem";
            emitirNotaToolStripMenuItem.Size = new Size(134, 22);
            emitirNotaToolStripMenuItem.Text = "&Emitir Nota";
            // 
            // configuraçãoToolStripMenuItem
            // 
            configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            configuraçãoToolStripMenuItem.Size = new Size(91, 20);
            configuraçãoToolStripMenuItem.Text = "Con&figuração";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 404);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Sistema Comercial TDS T01";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslUsuarioLogado;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem trocarDeUsuárioToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem operaçãoToolStripMenuItem;
        private ToolStripMenuItem movimentoToolStripMenuItem;
        private ToolStripMenuItem configuraçãoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem2;
        private ToolStripMenuItem listarToolStripMenuItem2;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem níveisToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem3;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem1;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem emitirNotaToolStripMenuItem;
        private Panel panel1;
    }
}