namespace Food_Control.Formularios
{
    partial class frmCadFood
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label comidaLabel;
            System.Windows.Forms.Label descriçãoLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label origemLabel;
            System.Windows.Forms.Label ingredientesLabel;
            System.Windows.Forms.Label aonde_comerLabel;
            System.Windows.Forms.Label preparoLabel;
            System.Windows.Forms.Label melhor_ChefLabel;
            System.Windows.Forms.Label preçoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFood));
            this.dataSet_Comidas = new Food_Control.Dados.DataSet_Comidas();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableAdapter = new Food_Control.Dados.DataSet_ComidasTableAdapters.FoodTableAdapter();
            this.tableAdapterManager = new Food_Control.Dados.DataSet_ComidasTableAdapters.TableAdapterManager();
            this.foodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.foodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.comidaTextBox = new System.Windows.Forms.TextBox();
            this.descriçãoTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.origemTextBox = new System.Windows.Forms.TextBox();
            this.ingredientesTextBox = new System.Windows.Forms.TextBox();
            this.aonde_comerTextBox = new System.Windows.Forms.TextBox();
            this.preparoTextBox = new System.Windows.Forms.TextBox();
            this.melhor_ChefTextBox = new System.Windows.Forms.TextBox();
            this.preçoTextBox = new System.Windows.Forms.TextBox();
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            comidaLabel = new System.Windows.Forms.Label();
            descriçãoLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            origemLabel = new System.Windows.Forms.Label();
            ingredientesLabel = new System.Windows.Forms.Label();
            aonde_comerLabel = new System.Windows.Forms.Label();
            preparoLabel = new System.Windows.Forms.Label();
            melhor_ChefLabel = new System.Windows.Forms.Label();
            preçoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Comidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingNavigator)).BeginInit();
            this.foodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(51, 55);
            iDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // comidaLabel
            // 
            comidaLabel.AutoSize = true;
            comidaLabel.Location = new System.Drawing.Point(51, 75);
            comidaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            comidaLabel.Name = "comidaLabel";
            comidaLabel.Size = new System.Drawing.Size(45, 13);
            comidaLabel.TabIndex = 3;
            comidaLabel.Text = "Comida:";
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Location = new System.Drawing.Point(51, 96);
            descriçãoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(58, 13);
            descriçãoLabel.TabIndex = 5;
            descriçãoLabel.Text = "Descrição:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(51, 117);
            categoriaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 7;
            categoriaLabel.Text = "Categoria:";
            // 
            // origemLabel
            // 
            origemLabel.AutoSize = true;
            origemLabel.Location = new System.Drawing.Point(51, 138);
            origemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            origemLabel.Name = "origemLabel";
            origemLabel.Size = new System.Drawing.Size(43, 13);
            origemLabel.TabIndex = 9;
            origemLabel.Text = "Origem:";
            // 
            // ingredientesLabel
            // 
            ingredientesLabel.AutoSize = true;
            ingredientesLabel.Location = new System.Drawing.Point(51, 159);
            ingredientesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ingredientesLabel.Name = "ingredientesLabel";
            ingredientesLabel.Size = new System.Drawing.Size(68, 13);
            ingredientesLabel.TabIndex = 11;
            ingredientesLabel.Text = "Ingredientes:";
            // 
            // aonde_comerLabel
            // 
            aonde_comerLabel.AutoSize = true;
            aonde_comerLabel.Location = new System.Drawing.Point(51, 179);
            aonde_comerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            aonde_comerLabel.Name = "aonde_comerLabel";
            aonde_comerLabel.Size = new System.Drawing.Size(73, 13);
            aonde_comerLabel.TabIndex = 13;
            aonde_comerLabel.Text = "Aonde comer:";
            // 
            // preparoLabel
            // 
            preparoLabel.AutoSize = true;
            preparoLabel.Location = new System.Drawing.Point(51, 200);
            preparoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            preparoLabel.Name = "preparoLabel";
            preparoLabel.Size = new System.Drawing.Size(47, 13);
            preparoLabel.TabIndex = 15;
            preparoLabel.Text = "Preparo:";
            // 
            // melhor_ChefLabel
            // 
            melhor_ChefLabel.AutoSize = true;
            melhor_ChefLabel.Location = new System.Drawing.Point(51, 221);
            melhor_ChefLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            melhor_ChefLabel.Name = "melhor_ChefLabel";
            melhor_ChefLabel.Size = new System.Drawing.Size(67, 13);
            melhor_ChefLabel.TabIndex = 17;
            melhor_ChefLabel.Text = "Melhor Chef:";
            // 
            // preçoLabel
            // 
            preçoLabel.AutoSize = true;
            preçoLabel.Location = new System.Drawing.Point(51, 242);
            preçoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            preçoLabel.Name = "preçoLabel";
            preçoLabel.Size = new System.Drawing.Size(38, 13);
            preçoLabel.TabIndex = 19;
            preçoLabel.Text = "Preço:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FoodTableAdapter = this.foodTableAdapter;
            this.tableAdapterManager.UpdateOrder = Food_Control.Dados.DataSet_ComidasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // foodBindingNavigator
            // 
            this.foodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.foodBindingNavigator.BindingSource = this.foodBindingSource;
            this.foodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.foodBindingNavigator.DeleteItem = null;
            this.foodBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.foodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.foodBindingNavigatorSaveItem});
            this.foodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.foodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.foodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.foodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.foodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.foodBindingNavigator.Name = "foodBindingNavigator";
            this.foodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.foodBindingNavigator.Size = new System.Drawing.Size(855, 31);
            this.foodBindingNavigator.TabIndex = 0;
            this.foodBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // foodBindingNavigatorSaveItem
            // 
            this.foodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.foodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("foodBindingNavigatorSaveItem.Image")));
            this.foodBindingNavigatorSaveItem.Name = "foodBindingNavigatorSaveItem";
            this.foodBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.foodBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.foodBindingNavigatorSaveItem.Click += new System.EventHandler(this.FoodBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(127, 53);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(187, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // comidaTextBox
            // 
            this.comidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Comida", true));
            this.comidaTextBox.Location = new System.Drawing.Point(127, 73);
            this.comidaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comidaTextBox.Name = "comidaTextBox";
            this.comidaTextBox.Size = new System.Drawing.Size(187, 20);
            this.comidaTextBox.TabIndex = 4;
            // 
            // descriçãoTextBox
            // 
            this.descriçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Descrição", true));
            this.descriçãoTextBox.Location = new System.Drawing.Point(127, 94);
            this.descriçãoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriçãoTextBox.Name = "descriçãoTextBox";
            this.descriçãoTextBox.Size = new System.Drawing.Size(187, 20);
            this.descriçãoTextBox.TabIndex = 6;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(127, 115);
            this.categoriaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(187, 20);
            this.categoriaTextBox.TabIndex = 8;
            // 
            // origemTextBox
            // 
            this.origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Origem", true));
            this.origemTextBox.Location = new System.Drawing.Point(127, 136);
            this.origemTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.origemTextBox.Name = "origemTextBox";
            this.origemTextBox.Size = new System.Drawing.Size(187, 20);
            this.origemTextBox.TabIndex = 10;
            // 
            // ingredientesTextBox
            // 
            this.ingredientesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Ingredientes", true));
            this.ingredientesTextBox.Location = new System.Drawing.Point(127, 157);
            this.ingredientesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ingredientesTextBox.Name = "ingredientesTextBox";
            this.ingredientesTextBox.Size = new System.Drawing.Size(187, 20);
            this.ingredientesTextBox.TabIndex = 12;
            // 
            // aonde_comerTextBox
            // 
            this.aonde_comerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Aonde_comer", true));
            this.aonde_comerTextBox.Location = new System.Drawing.Point(127, 177);
            this.aonde_comerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aonde_comerTextBox.Name = "aonde_comerTextBox";
            this.aonde_comerTextBox.Size = new System.Drawing.Size(187, 20);
            this.aonde_comerTextBox.TabIndex = 14;
            // 
            // preparoTextBox
            // 
            this.preparoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Preparo", true));
            this.preparoTextBox.Location = new System.Drawing.Point(127, 198);
            this.preparoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preparoTextBox.Name = "preparoTextBox";
            this.preparoTextBox.Size = new System.Drawing.Size(187, 20);
            this.preparoTextBox.TabIndex = 16;
            // 
            // melhor_ChefTextBox
            // 
            this.melhor_ChefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Melhor_Chef", true));
            this.melhor_ChefTextBox.Location = new System.Drawing.Point(127, 219);
            this.melhor_ChefTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.melhor_ChefTextBox.Name = "melhor_ChefTextBox";
            this.melhor_ChefTextBox.Size = new System.Drawing.Size(187, 20);
            this.melhor_ChefTextBox.TabIndex = 18;
            // 
            // preçoTextBox
            // 
            this.preçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Preço", true));
            this.preçoTextBox.Location = new System.Drawing.Point(127, 240);
            this.preçoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preçoTextBox.Name = "preçoTextBox";
            this.preçoTextBox.Size = new System.Drawing.Size(187, 20);
            this.preçoTextBox.TabIndex = 20;
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.AutoGenerateColumns = false;
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.foodDataGridView.DataSource = this.foodBindingSource;
            this.foodDataGridView.Location = new System.Drawing.Point(61, 290);
            this.foodDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.RowTemplate.Height = 28;
            this.foodDataGridView.Size = new System.Drawing.Size(713, 143);
            this.foodDataGridView.TabIndex = 21;
            this.foodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Comida";
            this.dataGridViewTextBoxColumn2.HeaderText = "Comida";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descrição";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Origem";
            this.dataGridViewTextBoxColumn5.HeaderText = "Origem";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ingredientes";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ingredientes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Aonde_comer";
            this.dataGridViewTextBoxColumn7.HeaderText = "Aonde_comer";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Preparo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Preparo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Melhor_Chef";
            this.dataGridViewTextBoxColumn9.HeaderText = "Melhor_Chef";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn10.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // frmCadFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 446);
            this.Controls.Add(this.foodDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(comidaLabel);
            this.Controls.Add(this.comidaTextBox);
            this.Controls.Add(descriçãoLabel);
            this.Controls.Add(this.descriçãoTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(origemLabel);
            this.Controls.Add(this.origemTextBox);
            this.Controls.Add(ingredientesLabel);
            this.Controls.Add(this.ingredientesTextBox);
            this.Controls.Add(aonde_comerLabel);
            this.Controls.Add(this.aonde_comerTextBox);
            this.Controls.Add(preparoLabel);
            this.Controls.Add(this.preparoTextBox);
            this.Controls.Add(melhor_ChefLabel);
            this.Controls.Add(this.melhor_ChefTextBox);
            this.Controls.Add(preçoLabel);
            this.Controls.Add(this.preçoTextBox);
            this.Controls.Add(this.foodBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCadFood";
            this.Text = "Cadastro das Comidas";
            this.Load += new System.EventHandler(this.FrmCadFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Comidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingNavigator)).EndInit();
            this.foodBindingNavigator.ResumeLayout(false);
            this.foodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DataSet_Comidas dataSet_Comidas;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private Dados.DataSet_ComidasTableAdapters.FoodTableAdapter foodTableAdapter;
        private Dados.DataSet_ComidasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator foodBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton foodBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox comidaTextBox;
        private System.Windows.Forms.TextBox descriçãoTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox origemTextBox;
        private System.Windows.Forms.TextBox ingredientesTextBox;
        private System.Windows.Forms.TextBox aonde_comerTextBox;
        private System.Windows.Forms.TextBox preparoTextBox;
        private System.Windows.Forms.TextBox melhor_ChefTextBox;
        private System.Windows.Forms.TextBox preçoTextBox;
        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}