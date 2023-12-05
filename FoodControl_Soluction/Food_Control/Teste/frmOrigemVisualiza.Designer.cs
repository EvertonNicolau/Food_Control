namespace Food_Control.Teste
{
    partial class frmOrigemVisualiza
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Comidas = new Food_Control.Dados.DataSet_Comidas();
            this.dataSetComidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Comidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Food_Control.Relatórios.RelatorioComidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Comidas
            // 
            this.dataSet_Comidas.DataSetName = "DataSet_Comidas";
            this.dataSet_Comidas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetComidasBindingSource
            // 
            this.dataSetComidasBindingSource.DataSource = this.dataSet_Comidas;
            this.dataSetComidasBindingSource.Position = 0;
            // 
            // FoodBindingSource
            // 
            this.FoodBindingSource.DataMember = "Food";
            this.FoodBindingSource.DataSource = this.dataSet_Comidas;
            // 
            // frmOrigemVisualiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmOrigemVisualiza";
            this.Text = "frmOrigemVisualiza";
            this.Load += new System.EventHandler(this.FrmOrigemVisualiza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Comidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.DataSet_Comidas dataSet_Comidas;
        private System.Windows.Forms.BindingSource dataSetComidasBindingSource;
        private System.Windows.Forms.BindingSource FoodBindingSource;
    }
}