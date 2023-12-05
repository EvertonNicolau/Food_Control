using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Control.Teste
{
    public partial class frmOrigemVisualiza : Form
    {
        public frmOrigemVisualiza()
        {
            InitializeComponent();
        }

        private void FrmOrigemVisualiza_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
