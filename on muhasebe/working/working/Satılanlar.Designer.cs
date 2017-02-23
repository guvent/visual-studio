namespace working
{
    partial class Satılanlar
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
            System.Windows.Forms.Label satılan_Ürün_AdıLabel;
            System.Windows.Forms.Label satış_TutarıLabel;
            System.Windows.Forms.Label satış_FiyatıLabel;
            System.Windows.Forms.Label kDVLabel;
            System.Windows.Forms.Label birimiLabel;
            System.Windows.Forms.Label miktarıLabel;
            System.Windows.Forms.Label belge_NoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satılanlar));
            this.satılanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cagbilDataSet = new working.cagbilDataSet();
            this.satılanlarTableAdapter = new working.cagbilDataSetTableAdapters.satılanlarTableAdapter();
            this.tableAdapterManager = new working.cagbilDataSetTableAdapters.TableAdapterManager();
            this.satılanlarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.satılanlarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.belge_NoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.satış_TutarıTextBox = new System.Windows.Forms.TextBox();
            this.satış_FiyatıTextBox = new System.Windows.Forms.TextBox();
            this.kDVTextBox = new System.Windows.Forms.TextBox();
            this.birimiTextBox = new System.Windows.Forms.TextBox();
            this.miktarıTextBox = new System.Windows.Forms.TextBox();
            this.satılan_Ürün_AdıTextBox = new System.Windows.Forms.TextBox();
            this.satılanlarDataGridView = new System.Windows.Forms.DataGridView();
            this.belgeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satışNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satılanÜrünAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satışFiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satışTutarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            satılan_Ürün_AdıLabel = new System.Windows.Forms.Label();
            satış_TutarıLabel = new System.Windows.Forms.Label();
            satış_FiyatıLabel = new System.Windows.Forms.Label();
            kDVLabel = new System.Windows.Forms.Label();
            birimiLabel = new System.Windows.Forms.Label();
            miktarıLabel = new System.Windows.Forms.Label();
            belge_NoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.satılanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagbilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satılanlarBindingNavigator)).BeginInit();
            this.satılanlarBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satılanlarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // satılan_Ürün_AdıLabel
            // 
            satılan_Ürün_AdıLabel.AutoSize = true;
            satılan_Ürün_AdıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            satılan_Ürün_AdıLabel.Location = new System.Drawing.Point(3, 9);
            satılan_Ürün_AdıLabel.Name = "satılan_Ürün_AdıLabel";
            satılan_Ürün_AdıLabel.Size = new System.Drawing.Size(166, 24);
            satılan_Ürün_AdıLabel.TabIndex = 2;
            satılan_Ürün_AdıLabel.Text = "Satılan Ürün Adı:";
            // 
            // satış_TutarıLabel
            // 
            satış_TutarıLabel.AutoSize = true;
            satış_TutarıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            satış_TutarıLabel.Location = new System.Drawing.Point(230, 93);
            satış_TutarıLabel.Name = "satış_TutarıLabel";
            satış_TutarıLabel.Size = new System.Drawing.Size(106, 20);
            satış_TutarıLabel.TabIndex = 22;
            satış_TutarıLabel.Text = "Satış Tutarı:";
            // 
            // satış_FiyatıLabel
            // 
            satış_FiyatıLabel.AutoSize = true;
            satış_FiyatıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            satış_FiyatıLabel.Location = new System.Drawing.Point(234, 12);
            satış_FiyatıLabel.Name = "satış_FiyatıLabel";
            satış_FiyatıLabel.Size = new System.Drawing.Size(103, 20);
            satış_FiyatıLabel.TabIndex = 20;
            satış_FiyatıLabel.Text = "Satış Fiyatı:";
            // 
            // kDVLabel
            // 
            kDVLabel.AutoSize = true;
            kDVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kDVLabel.Location = new System.Drawing.Point(234, 45);
            kDVLabel.Name = "kDVLabel";
            kDVLabel.Size = new System.Drawing.Size(50, 20);
            kDVLabel.TabIndex = 18;
            kDVLabel.Text = "KDV:";
            // 
            // birimiLabel
            // 
            birimiLabel.AutoSize = true;
            birimiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            birimiLabel.Location = new System.Drawing.Point(4, 43);
            birimiLabel.Name = "birimiLabel";
            birimiLabel.Size = new System.Drawing.Size(58, 20);
            birimiLabel.TabIndex = 16;
            birimiLabel.Text = "Birimi:";
            // 
            // miktarıLabel
            // 
            miktarıLabel.AutoSize = true;
            miktarıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            miktarıLabel.Location = new System.Drawing.Point(4, 12);
            miktarıLabel.Name = "miktarıLabel";
            miktarıLabel.Size = new System.Drawing.Size(67, 20);
            miktarıLabel.TabIndex = 14;
            miktarıLabel.Text = "Miktarı:";
            // 
            // belge_NoLabel
            // 
            belge_NoLabel.AutoSize = true;
            belge_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            belge_NoLabel.Location = new System.Drawing.Point(26, 7);
            belge_NoLabel.Name = "belge_NoLabel";
            belge_NoLabel.Size = new System.Drawing.Size(77, 16);
            belge_NoLabel.TabIndex = 2;
            belge_NoLabel.Text = "Belge No:";
            // 
            // satılanlarBindingSource
            // 
            this.satılanlarBindingSource.DataMember = "satılanlar";
            this.satılanlarBindingSource.DataSource = this.cagbilDataSet;
            // 
            // cagbilDataSet
            // 
            this.cagbilDataSet.DataSetName = "cagbilDataSet";
            this.cagbilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satılanlarTableAdapter
            // 
            this.satılanlarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.müşterilerTableAdapter = null;
            this.tableAdapterManager.satılanlarTableAdapter = this.satılanlarTableAdapter;
            this.tableAdapterManager.satisTableAdapter = null;
            this.tableAdapterManager.tamiregelenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = working.cagbilDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ürünlerTableAdapter = null;
            this.tableAdapterManager.yapılanişlemlerTableAdapter = null;
            // 
            // satılanlarBindingNavigator
            // 
            this.satılanlarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.satılanlarBindingNavigator.BindingSource = this.satılanlarBindingSource;
            this.satılanlarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.satılanlarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.satılanlarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.satılanlarBindingNavigatorSaveItem});
            this.satılanlarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.satılanlarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.satılanlarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.satılanlarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.satılanlarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.satılanlarBindingNavigator.Name = "satılanlarBindingNavigator";
            this.satılanlarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.satılanlarBindingNavigator.Size = new System.Drawing.Size(711, 25);
            this.satılanlarBindingNavigator.TabIndex = 0;
            this.satılanlarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // satılanlarBindingNavigatorSaveItem
            // 
            this.satılanlarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.satılanlarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("satılanlarBindingNavigatorSaveItem.Image")));
            this.satılanlarBindingNavigatorSaveItem.Name = "satılanlarBindingNavigatorSaveItem";
            this.satılanlarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.satılanlarBindingNavigatorSaveItem.Text = "Save Data";
            this.satılanlarBindingNavigatorSaveItem.Click += new System.EventHandler(this.satılanlarBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(satılan_Ürün_AdıLabel);
            this.panel1.Controls.Add(this.satılan_Ürün_AdıTextBox);
            this.panel1.Location = new System.Drawing.Point(13, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 176);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(belge_NoLabel);
            this.panel4.Controls.Add(this.belge_NoTextBox);
            this.panel4.Location = new System.Drawing.Point(551, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 67);
            this.panel4.TabIndex = 5;
            // 
            // belge_NoTextBox
            // 
            this.belge_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satılanlarBindingSource, "Belge No", true));
            this.belge_NoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.belge_NoTextBox.Location = new System.Drawing.Point(14, 33);
            this.belge_NoTextBox.Name = "belge_NoTextBox";
            this.belge_NoTextBox.Size = new System.Drawing.Size(100, 22);
            this.belge_NoTextBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(satış_TutarıLabel);
            this.panel2.Controls.Add(this.satış_TutarıTextBox);
            this.panel2.Controls.Add(satış_FiyatıLabel);
            this.panel2.Controls.Add(this.satış_FiyatıTextBox);
            this.panel2.Controls.Add(kDVLabel);
            this.panel2.Controls.Add(this.kDVTextBox);
            this.panel2.Controls.Add(birimiLabel);
            this.panel2.Controls.Add(this.birimiTextBox);
            this.panel2.Controls.Add(miktarıLabel);
            this.panel2.Controls.Add(this.miktarıTextBox);
            this.panel2.Location = new System.Drawing.Point(7, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 128);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(217, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 124);
            this.panel3.TabIndex = 24;
            // 
            // satış_TutarıTextBox
            // 
            this.satış_TutarıTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satılanlarBindingSource, "Satış Tutarı", true));
            this.satış_TutarıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satış_TutarıTextBox.Location = new System.Drawing.Point(340, 90);
            this.satış_TutarıTextBox.Name = "satış_TutarıTextBox";
            this.satış_TutarıTextBox.Size = new System.Drawing.Size(162, 26);
            this.satış_TutarıTextBox.TabIndex = 23;
            // 
            // satış_FiyatıTextBox
            // 
            this.satış_FiyatıTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satılanlarBindingSource, "Satış Fiyatı", true));
            this.satış_FiyatıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satış_FiyatıTextBox.Location = new System.Drawing.Point(340, 9);
            this.satış_FiyatıTextBox.Name = "satış_FiyatıTextBox";
            this.satış_FiyatıTextBox.Size = new System.Drawing.Size(162, 26);
            this.satış_FiyatıTextBox.TabIndex = 21;
            // 
            // kDVTextBox
            // 
            this.kDVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satılanlarBindingSource, "KDV", true));
            this.kDVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kDVTextBox.Location = new System.Drawing.Point(340, 42);
            this.kDVTextBox.Name = "kDVTextBox";
            this.kDVTextBox.Size = new System.Drawing.Size(100, 26);
            this.kDVTextBox.TabIndex = 19;
            // 
            // birimiTextBox
            // 
            this.birimiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satılanlarBindingSource, "Birimi", true));
            this.birimiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimiTextBox.Location = new System.Drawing.Point(74, 40);
            this.birimiTextBox.Name = "birimiTextBox";
            this.birimiTextBox.Size = new System.Drawing.Size(135, 26);
            this.birimiTextBox.TabIndex = 17;
            // 
            // miktarıTextBox
            // 
            this.miktarıTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satılanlarBindingSource, "Miktarı", true));
            this.miktarıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarıTextBox.Location = new System.Drawing.Point(74, 9);
            this.miktarıTextBox.Name = "miktarıTextBox";
            this.miktarıTextBox.Size = new System.Drawing.Size(135, 26);
            this.miktarıTextBox.TabIndex = 15;
            // 
            // satılan_Ürün_AdıTextBox
            // 
            this.satılan_Ürün_AdıTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satılanlarBindingSource, "Satılan Ürün Adı", true));
            this.satılan_Ürün_AdıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satılan_Ürün_AdıTextBox.Location = new System.Drawing.Point(173, 6);
            this.satılan_Ürün_AdıTextBox.Name = "satılan_Ürün_AdıTextBox";
            this.satılan_Ürün_AdıTextBox.Size = new System.Drawing.Size(365, 29);
            this.satılan_Ürün_AdıTextBox.TabIndex = 3;
            // 
            // satılanlarDataGridView
            // 
            this.satılanlarDataGridView.AutoGenerateColumns = false;
            this.satılanlarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satılanlarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.belgeNoDataGridViewTextBoxColumn,
            this.satışNoDataGridViewTextBoxColumn,
            this.satılanÜrünAdıDataGridViewTextBoxColumn,
            this.miktarıDataGridViewTextBoxColumn,
            this.birimiDataGridViewTextBoxColumn,
            this.kDVDataGridViewTextBoxColumn,
            this.satışFiyatıDataGridViewTextBoxColumn,
            this.satışTutarıDataGridViewTextBoxColumn});
            this.satılanlarDataGridView.DataSource = this.satılanlarBindingSource;
            this.satılanlarDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.satılanlarDataGridView.Location = new System.Drawing.Point(0, 212);
            this.satılanlarDataGridView.Name = "satılanlarDataGridView";
            this.satılanlarDataGridView.Size = new System.Drawing.Size(711, 258);
            this.satılanlarDataGridView.TabIndex = 2;
            // 
            // belgeNoDataGridViewTextBoxColumn
            // 
            this.belgeNoDataGridViewTextBoxColumn.DataPropertyName = "Belge No";
            this.belgeNoDataGridViewTextBoxColumn.HeaderText = "Belge No";
            this.belgeNoDataGridViewTextBoxColumn.Name = "belgeNoDataGridViewTextBoxColumn";
            // 
            // satışNoDataGridViewTextBoxColumn
            // 
            this.satışNoDataGridViewTextBoxColumn.DataPropertyName = "Satış No";
            this.satışNoDataGridViewTextBoxColumn.HeaderText = "Satış No";
            this.satışNoDataGridViewTextBoxColumn.Name = "satışNoDataGridViewTextBoxColumn";
            // 
            // satılanÜrünAdıDataGridViewTextBoxColumn
            // 
            this.satılanÜrünAdıDataGridViewTextBoxColumn.DataPropertyName = "Satılan Ürün Adı";
            this.satılanÜrünAdıDataGridViewTextBoxColumn.HeaderText = "Satılan Ürün Adı";
            this.satılanÜrünAdıDataGridViewTextBoxColumn.Name = "satılanÜrünAdıDataGridViewTextBoxColumn";
            // 
            // miktarıDataGridViewTextBoxColumn
            // 
            this.miktarıDataGridViewTextBoxColumn.DataPropertyName = "Miktarı";
            this.miktarıDataGridViewTextBoxColumn.HeaderText = "Miktarı";
            this.miktarıDataGridViewTextBoxColumn.Name = "miktarıDataGridViewTextBoxColumn";
            // 
            // birimiDataGridViewTextBoxColumn
            // 
            this.birimiDataGridViewTextBoxColumn.DataPropertyName = "Birimi";
            this.birimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.birimiDataGridViewTextBoxColumn.Name = "birimiDataGridViewTextBoxColumn";
            // 
            // kDVDataGridViewTextBoxColumn
            // 
            this.kDVDataGridViewTextBoxColumn.DataPropertyName = "KDV";
            this.kDVDataGridViewTextBoxColumn.HeaderText = "KDV";
            this.kDVDataGridViewTextBoxColumn.Name = "kDVDataGridViewTextBoxColumn";
            // 
            // satışFiyatıDataGridViewTextBoxColumn
            // 
            this.satışFiyatıDataGridViewTextBoxColumn.DataPropertyName = "Satış Fiyatı";
            this.satışFiyatıDataGridViewTextBoxColumn.HeaderText = "Satış Fiyatı";
            this.satışFiyatıDataGridViewTextBoxColumn.Name = "satışFiyatıDataGridViewTextBoxColumn";
            // 
            // satışTutarıDataGridViewTextBoxColumn
            // 
            this.satışTutarıDataGridViewTextBoxColumn.DataPropertyName = "Satış Tutarı";
            this.satışTutarıDataGridViewTextBoxColumn.HeaderText = "Satış Tutarı";
            this.satışTutarıDataGridViewTextBoxColumn.Name = "satışTutarıDataGridViewTextBoxColumn";
            // 
            // Satılanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 470);
            this.Controls.Add(this.satılanlarDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.satılanlarBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Satılanlar";
            this.Text = "Satılanlar";
            this.Load += new System.EventHandler(this.Satılanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satılanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagbilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satılanlarBindingNavigator)).EndInit();
            this.satılanlarBindingNavigator.ResumeLayout(false);
            this.satılanlarBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satılanlarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource satılanlarBindingSource;
        private cagbilDataSetTableAdapters.satılanlarTableAdapter satılanlarTableAdapter;
        private cagbilDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator satılanlarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton satılanlarBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox satılan_Ürün_AdıTextBox;
        private System.Windows.Forms.DataGridView satılanlarDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox satış_TutarıTextBox;
        private System.Windows.Forms.TextBox satış_FiyatıTextBox;
        private System.Windows.Forms.TextBox kDVTextBox;
        private System.Windows.Forms.TextBox birimiTextBox;
        private System.Windows.Forms.TextBox miktarıTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox belge_NoTextBox;
        private cagbilDataSet cagbilDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satışNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satılanÜrünAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satışFiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satışTutarıDataGridViewTextBoxColumn;
    }
}