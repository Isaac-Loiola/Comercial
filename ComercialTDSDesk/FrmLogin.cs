﻿using ComercialTDSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExibirSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text == "&Voltar")
            {
                Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Program.UsuarioLogado = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);

            if (Program.UsuarioLogado.Id > 0)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Email e/ou senha incorretos \n ou usuário não cadastrado");
                // cursor volta para o txt
                txtEmail.Focus();
                // seleciona tudo de txt
                txtEmail.SelectAll();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
