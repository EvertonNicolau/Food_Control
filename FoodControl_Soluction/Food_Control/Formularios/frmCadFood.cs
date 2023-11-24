using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Control.Formularios
{
    public partial class frmCadFood : Form
    {
        public frmCadFood()
        {
            InitializeComponent();
        }

        private void FoodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Comidas);

        }

        private void FrmCadFood_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Comidas.Food'. Você pode movê-la ou removê-la conforme necessário.
            this.foodTableAdapter.Fill(this.dataSet_Comidas.Food);

        }

        private void FoodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
