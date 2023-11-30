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
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Comidas.Food'. Você pode movê-la ou removê-la conforme necessário.
            this.foodTableAdapter.Fill(this.dataSet_Comidas.Food);

            this.reportViewer1.RefreshReport();
        }
    }
}
