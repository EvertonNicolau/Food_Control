
namespace Food_Control.Formulários
{
    partial class frmVisualizaListaComidas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Comidas = new Food_Control.Dados.DataSet_Comidas();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableAdapter = new Food_Control.Dados.DataSet_ComidasTableAdapters.FoodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Comidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            //this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Pratos";
            reportDataSource1.Value = this.foodBindingSource;
            //this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Food_Control.Relatórios.RelatorioComidas.rdlc";
            //this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.ServerReport.BearerToken = null;
            //this.reportViewer1.Size = new System.Drawing.Size(1209, 556);
            //this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Comidas
            // 
            this.dataSet_Comidas.DataSetName = "DataSet_Comidas";
            this.dataSet_Comidas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.dataSet_Comidas;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizaListaComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 556);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisualizaListaComidas";
            this.Text = "frmVisualizaListaComidas";
            this.Load += new System.EventHandler(this.frmVisualizaListaComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Comidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.DataSet_Comidas dataSet_Comidas;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private Dados.DataSet_ComidasTableAdapters.FoodTableAdapter foodTableAdapter;
    }
}