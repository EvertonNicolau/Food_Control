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

namespace Food_Control
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFood objCadFood = new frmCadFood();
            objCadFood.MdiParent = this;
            objCadFood.Show();
        }

        private void relatórioDePratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaListaComidas objVisualiza = new frmVisualizaListaComidas();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            var loginMenu = new frmLogin();
            loginMenu.Show();

            this.Visible = false;
        }
           
        }
    }

