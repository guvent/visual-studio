namespace kres
{
    partial class ogrenci
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
            System.Windows.Forms.Label tC_No__Label;
            System.Windows.Forms.Label adı__Label;
            System.Windows.Forms.Label soyadı__Label;
            System.Windows.Forms.Label doğum_Yeri__Label;
            System.Windows.Forms.Label doğum_Tarihi__Label;
            System.Windows.Forms.Label cinsiyet__Label;
            System.Windows.Forms.Label sınıfı__Label;
            System.Windows.Forms.Label kayıt_No__Label;
            System.Windows.Forms.Label adres__Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenci));
            this.kresDataSet = new kres.kresDataSet();
            this.kbs = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new kres.kresDataSetTableAdapters.ogrenciTableAdapter();
            this.tableAdapterManager = new kres.kresDataSetTableAdapters.TableAdapterManager();
            this.ogrenciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ogrenciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ogrenciDataGridView = new System.Windows.Forms.DataGridView();
            this.tC_No__TextBox = new System.Windows.Forms.TextBox();
            this.adı__TextBox = new System.Windows.Forms.TextBox();
            this.soyadı__TextBox = new System.Windows.Forms.TextBox();
            this.doğum_Yeri__TextBox = new System.Windows.Forms.TextBox();
            this.doğum_Tarihi__DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cinsiyet__TextBox = new System.Windows.Forms.TextBox();
            this.sınıfı__TextBox = new System.Windows.Forms.TextBox();
            this.kayıt_No__TextBox = new System.Windows.Forms.TextBox();
            this.adres__TextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
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
            this.button5 = new System.Windows.Forms.Button();
            tC_No__Label = new System.Windows.Forms.Label();
            adı__Label = new System.Windows.Forms.Label();
            soyadı__Label = new System.Windows.Forms.Label();
            doğum_Yeri__Label = new System.Windows.Forms.Label();
            doğum_Tarihi__Label = new System.Windows.Forms.Label();
            cinsiyet__Label = new System.Windows.Forms.Label();
            sınıfı__Label = new System.Windows.Forms.Label();
            kayıt_No__Label = new System.Windows.Forms.Label();
            adres__Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingNavigator)).BeginInit();
            this.ogrenciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tC_No__Label
            // 
            tC_No__Label.AutoSize = true;
            tC_No__Label.Location = new System.Drawing.Point(57, 88);
            tC_No__Label.Name = "tC_No__Label";
            tC_No__Label.Size = new System.Drawing.Size(44, 13);
            tC_No__Label.TabIndex = 2;
            tC_No__Label.Text = "TC No :";
            // 
            // adı__Label
            // 
            adı__Label.AutoSize = true;
            adı__Label.Location = new System.Drawing.Point(354, 89);
            adı__Label.Name = "adı__Label";
            adı__Label.Size = new System.Drawing.Size(28, 13);
            adı__Label.TabIndex = 4;
            adı__Label.Text = "Adı :";
            // 
            // soyadı__Label
            // 
            soyadı__Label.AutoSize = true;
            soyadı__Label.Location = new System.Drawing.Point(337, 115);
            soyadı__Label.Name = "soyadı__Label";
            soyadı__Label.Size = new System.Drawing.Size(45, 13);
            soyadı__Label.TabIndex = 6;
            soyadı__Label.Text = "Soyadı :";
            // 
            // doğum_Yeri__Label
            // 
            doğum_Yeri__Label.AutoSize = true;
            doğum_Yeri__Label.Location = new System.Drawing.Point(33, 114);
            doğum_Yeri__Label.Name = "doğum_Yeri__Label";
            doğum_Yeri__Label.Size = new System.Drawing.Size(68, 13);
            doğum_Yeri__Label.TabIndex = 8;
            doğum_Yeri__Label.Text = "Doğum Yeri :";
            // 
            // doğum_Tarihi__Label
            // 
            doğum_Tarihi__Label.AutoSize = true;
            doğum_Tarihi__Label.Location = new System.Drawing.Point(25, 141);
            doğum_Tarihi__Label.Name = "doğum_Tarihi__Label";
            doğum_Tarihi__Label.Size = new System.Drawing.Size(76, 13);
            doğum_Tarihi__Label.TabIndex = 10;
            doğum_Tarihi__Label.Text = "Doğum Tarihi :";
            // 
            // cinsiyet__Label
            // 
            cinsiyet__Label.AutoSize = true;
            cinsiyet__Label.Location = new System.Drawing.Point(333, 144);
            cinsiyet__Label.Name = "cinsiyet__Label";
            cinsiyet__Label.Size = new System.Drawing.Size(49, 13);
            cinsiyet__Label.TabIndex = 12;
            cinsiyet__Label.Text = "Cinsiyet :";
            // 
            // sınıfı__Label
            // 
            sınıfı__Label.AutoSize = true;
            sınıfı__Label.Location = new System.Drawing.Point(347, 170);
            sınıfı__Label.Name = "sınıfı__Label";
            sınıfı__Label.Size = new System.Drawing.Size(35, 13);
            sınıfı__Label.TabIndex = 14;
            sınıfı__Label.Text = "Sınıfı :";
            // 
            // kayıt_No__Label
            // 
            kayıt_No__Label.AutoSize = true;
            kayıt_No__Label.Location = new System.Drawing.Point(329, 196);
            kayıt_No__Label.Name = "kayıt_No__Label";
            kayıt_No__Label.Size = new System.Drawing.Size(53, 13);
            kayıt_No__Label.TabIndex = 16;
            kayıt_No__Label.Text = "Kayıt No :";
            // 
            // adres__Label
            // 
            adres__Label.AutoSize = true;
            adres__Label.Location = new System.Drawing.Point(61, 168);
            adres__Label.Name = "adres__Label";
            adres__Label.Size = new System.Drawing.Size(40, 13);
            adres__Label.TabIndex = 18;
            adres__Label.Text = "Adres :";
            // 
            // kresDataSet
            // 
            this.kresDataSet.DataSetName = "kresDataSet";
            this.kresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kbs
            // 
            this.kbs.DataMember = "ogrenci";
            this.kbs.DataSource = this.kresDataSet;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.etkinlikTableAdapter = null;
            this.tableAdapterManager.ogrenciTableAdapter = this.ogrenciTableAdapter;
            this.tableAdapterManager.personelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kres.kresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veliTableAdapter = null;
            this.tableAdapterManager.yemekTableAdapter = null;
            // 
            // ogrenciBindingNavigator
            // 
            this.ogrenciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ogrenciBindingNavigator.BindingSource = this.kbs;
            this.ogrenciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ogrenciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ogrenciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ogrenciBindingNavigatorSaveItem});
            this.ogrenciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ogrenciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ogrenciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ogrenciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ogrenciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ogrenciBindingNavigator.Name = "ogrenciBindingNavigator";
            this.ogrenciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ogrenciBindingNavigator.Size = new System.Drawing.Size(676, 25);
            this.ogrenciBindingNavigator.TabIndex = 0;
            this.ogrenciBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            // ogrenciBindingNavigatorSaveItem
            // 
            this.ogrenciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ogrenciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ogrenciBindingNavigatorSaveItem.Image")));
            this.ogrenciBindingNavigatorSaveItem.Name = "ogrenciBindingNavigatorSaveItem";
            this.ogrenciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ogrenciBindingNavigatorSaveItem.Text = "Save Data";
            this.ogrenciBindingNavigatorSaveItem.Click += new System.EventHandler(this.ogrenciBindingNavigatorSaveItem_Click);
            // 
            // ogrenciDataGridView
            // 
            this.ogrenciDataGridView.AllowUserToAddRows = false;
            this.ogrenciDataGridView.AutoGenerateColumns = false;
            this.ogrenciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.ogrenciDataGridView.DataSource = this.kbs;
            this.ogrenciDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ogrenciDataGridView.Location = new System.Drawing.Point(0, 226);
            this.ogrenciDataGridView.Name = "ogrenciDataGridView";
            this.ogrenciDataGridView.Size = new System.Drawing.Size(676, 263);
            this.ogrenciDataGridView.TabIndex = 1;
            // 
            // tC_No__TextBox
            // 
            this.tC_No__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "TC No :", true));
            this.tC_No__TextBox.Location = new System.Drawing.Point(107, 87);
            this.tC_No__TextBox.Name = "tC_No__TextBox";
            this.tC_No__TextBox.Size = new System.Drawing.Size(178, 20);
            this.tC_No__TextBox.TabIndex = 3;
            // 
            // adı__TextBox
            // 
            this.adı__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Adı :", true));
            this.adı__TextBox.Location = new System.Drawing.Point(388, 88);
            this.adı__TextBox.Name = "adı__TextBox";
            this.adı__TextBox.Size = new System.Drawing.Size(148, 20);
            this.adı__TextBox.TabIndex = 5;
            // 
            // soyadı__TextBox
            // 
            this.soyadı__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Soyadı :", true));
            this.soyadı__TextBox.Location = new System.Drawing.Point(388, 114);
            this.soyadı__TextBox.Name = "soyadı__TextBox";
            this.soyadı__TextBox.Size = new System.Drawing.Size(148, 20);
            this.soyadı__TextBox.TabIndex = 7;
            // 
            // doğum_Yeri__TextBox
            // 
            this.doğum_Yeri__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Doğum Yeri :", true));
            this.doğum_Yeri__TextBox.Location = new System.Drawing.Point(107, 113);
            this.doğum_Yeri__TextBox.Name = "doğum_Yeri__TextBox";
            this.doğum_Yeri__TextBox.Size = new System.Drawing.Size(178, 20);
            this.doğum_Yeri__TextBox.TabIndex = 9;
            // 
            // doğum_Tarihi__DateTimePicker
            // 
            this.doğum_Tarihi__DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kbs, "Doğum Tarihi :", true));
            this.doğum_Tarihi__DateTimePicker.Location = new System.Drawing.Point(107, 139);
            this.doğum_Tarihi__DateTimePicker.Name = "doğum_Tarihi__DateTimePicker";
            this.doğum_Tarihi__DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.doğum_Tarihi__DateTimePicker.TabIndex = 11;
            // 
            // cinsiyet__TextBox
            // 
            this.cinsiyet__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Cinsiyet :", true));
            this.cinsiyet__TextBox.Location = new System.Drawing.Point(388, 141);
            this.cinsiyet__TextBox.Name = "cinsiyet__TextBox";
            this.cinsiyet__TextBox.Size = new System.Drawing.Size(148, 20);
            this.cinsiyet__TextBox.TabIndex = 13;
            // 
            // sınıfı__TextBox
            // 
            this.sınıfı__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Sınıfı :", true));
            this.sınıfı__TextBox.Location = new System.Drawing.Point(388, 167);
            this.sınıfı__TextBox.Name = "sınıfı__TextBox";
            this.sınıfı__TextBox.Size = new System.Drawing.Size(148, 20);
            this.sınıfı__TextBox.TabIndex = 15;
            // 
            // kayıt_No__TextBox
            // 
            this.kayıt_No__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Kayıt No :", true));
            this.kayıt_No__TextBox.Location = new System.Drawing.Point(388, 193);
            this.kayıt_No__TextBox.Name = "kayıt_No__TextBox";
            this.kayıt_No__TextBox.Size = new System.Drawing.Size(148, 20);
            this.kayıt_No__TextBox.TabIndex = 17;
            // 
            // adres__TextBox
            // 
            this.adres__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Adres :", true));
            this.adres__TextBox.Location = new System.Drawing.Point(107, 165);
            this.adres__TextBox.Multiline = true;
            this.adres__TextBox.Name = "adres__TextBox";
            this.adres__TextBox.Size = new System.Drawing.Size(200, 48);
            this.adres__TextBox.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 37);
            this.button3.TabIndex = 22;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(21, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 47);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adını Girin :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(11, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(201, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 0;
            this.button4.Text = "BUL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TC No :";
            this.dataGridViewTextBoxColumn2.HeaderText = "TC No :";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adı :";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adı :";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Soyadı :";
            this.dataGridViewTextBoxColumn4.HeaderText = "Soyadı :";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Doğum Yeri :";
            this.dataGridViewTextBoxColumn5.HeaderText = "Doğum Yeri :";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Doğum Tarihi :";
            this.dataGridViewTextBoxColumn6.HeaderText = "Doğum Tarihi :";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cinsiyet :";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cinsiyet :";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sınıfı :";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sınıfı :";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Kayıt No :";
            this.dataGridViewTextBoxColumn9.HeaderText = "Kayıt No :";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Adres :";
            this.dataGridViewTextBoxColumn10.HeaderText = "Adres :";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(280, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 2;
            this.button5.Text = "Velisi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(676, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(adres__Label);
            this.Controls.Add(this.adres__TextBox);
            this.Controls.Add(kayıt_No__Label);
            this.Controls.Add(this.kayıt_No__TextBox);
            this.Controls.Add(sınıfı__Label);
            this.Controls.Add(this.sınıfı__TextBox);
            this.Controls.Add(cinsiyet__Label);
            this.Controls.Add(this.cinsiyet__TextBox);
            this.Controls.Add(doğum_Tarihi__Label);
            this.Controls.Add(this.doğum_Tarihi__DateTimePicker);
            this.Controls.Add(doğum_Yeri__Label);
            this.Controls.Add(this.doğum_Yeri__TextBox);
            this.Controls.Add(soyadı__Label);
            this.Controls.Add(this.soyadı__TextBox);
            this.Controls.Add(adı__Label);
            this.Controls.Add(this.adı__TextBox);
            this.Controls.Add(tC_No__Label);
            this.Controls.Add(this.tC_No__TextBox);
            this.Controls.Add(this.ogrenciDataGridView);
            this.Controls.Add(this.ogrenciBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ogrenci";
            this.Text = "Öğrenciler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ogrenci_FormClosing);
            this.Load += new System.EventHandler(this.ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingNavigator)).EndInit();
            this.ogrenciBindingNavigator.ResumeLayout(false);
            this.ogrenciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kresDataSet kresDataSet;
        private kresDataSetTableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
        private kresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ogrenciBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ogrenciBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ogrenciDataGridView;
        private System.Windows.Forms.TextBox tC_No__TextBox;
        private System.Windows.Forms.TextBox adı__TextBox;
        private System.Windows.Forms.TextBox soyadı__TextBox;
        private System.Windows.Forms.TextBox doğum_Yeri__TextBox;
        private System.Windows.Forms.DateTimePicker doğum_Tarihi__DateTimePicker;
        private System.Windows.Forms.TextBox cinsiyet__TextBox;
        private System.Windows.Forms.TextBox sınıfı__TextBox;
        private System.Windows.Forms.TextBox kayıt_No__TextBox;
        private System.Windows.Forms.TextBox adres__TextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.BindingSource kbs;
    }
}