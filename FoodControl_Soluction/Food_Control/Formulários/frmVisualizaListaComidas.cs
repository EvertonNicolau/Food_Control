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
    public partial class frmVisualizaListaComidas : Form
    {
        public frmVisualizaListaComidas()
        {
            InitializeComponent();
        }

        private void frmVisualizaListaComidas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
