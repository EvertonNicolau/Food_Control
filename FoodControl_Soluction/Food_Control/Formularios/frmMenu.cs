using Food_Control.Formularios;
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
    }
}
