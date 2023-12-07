using Food_Control.Formularios;
using Food_Control.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Control.Formulários
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void CaixaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaixaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {                
                    if (CaixaUsuario.Text.Equals("everton nicolau") && CaixaSenha.Text.Equals("123456"))
                    {
                        frmMenu AbrirMenu = new frmMenu();       
                        AbrirMenu.Show();
                    }

                    else if (CaixaUsuario.Text.Equals("everton nicolau") && CaixaSenha.Text != ("123456") && CaixaSenha.Text != (""))
                    {
                        MessageBox.Show("tem alguma coisa incorreta na sua senha, mano (a)" + MessageBoxButtons.OK);
                        CaixaSenha.Text = "";
                    }

                    else if (CaixaUsuario.Text.Equals("") && CaixaSenha.Text.Equals(""))
                    {
                        MessageBox.Show("digite suas informações aí, por favor!" + MessageBoxButtons.OK);
                        CaixaUsuario.Text = "";
                        CaixaSenha.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("usuáre e senha incorretos" + MessageBoxButtons.OK);
                        CaixaUsuario.Text = "";
                        CaixaSenha.Text = "";
                    }
               

                          
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
