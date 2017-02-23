namespace kres
{
    partial class veli
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
            System.Windows.Forms.Label öğrenci_TC__Label;
            System.Windows.Forms.Label veli_Tipi__Label;
            System.Windows.Forms.Label telefon__Label;
            System.Windows.Forms.Label veli_Adı_Soyadı__Label;
            System.Windows.Forms.Label adres__Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(veli));
            this.kresDataSet = new kres.kresDataSet();
            this.kbs = new System.Windows.Forms.BindingSource(this.components);
            this.veliTableAdapter = new kres.kresDataSetTableAdapters.veliTableAdapter();
            this.tableAdapterManager = new kres.kresDataSetTableAdapters.TableAdapterManager();
            this.veliBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.veliBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.veliDataGridView = new System.Windows.Forms.DataGridView();
            this.öğrenci_TC__TextBox = new System.Windows.Forms.TextBox();
            this.veli_Tipi__TextBox = new System.Windows.Forms.TextBox();
            this.telefon__TextBox = new System.Windows.Forms.TextBox();
            this.veli_Adı_Soyadı__TextBox = new System.Windows.Forms.TextBox();
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
            this.button5 = new System.Windows.Forms.Button();
            öğrenci_TC__Label = new System.Windows.Forms.Label();
            veli_Tipi__Label = new System.Windows.Forms.Label();
            telefon__Label = new System.Windows.Forms.Label();
            veli_Adı_Soyadı__Label = new System.Windows.Forms.Label();
            adres__Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veliBindingNavigator)).BeginInit();
            this.veliBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veliDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // öğrenci_TC__Label
            // 
            öğrenci_TC__Label.AutoSize = true;
            öğrenci_TC__Label.Location = new System.Drawing.Point(15, 97);
            öğrenci_TC__Label.Name = "öğrenci_TC__Label";
            öğrenci_TC__Label.Size = new System.Drawing.Size(67, 13);
            öğrenci_TC__Label.TabIndex = 2;
            öğrenci_TC__Label.Text = "Öğrenci TC :";
            // 
            // veli_Tipi__Label
            // 
            veli_Tipi__Label.AutoSize = true;
            veli_Tipi__Label.Location = new System.Drawing.Point(250, 123);
            veli_Tipi__Label.Name = "veli_Tipi__Label";
            veli_Tipi__Label.Size = new System.Drawing.Size(50, 13);
            veli_Tipi__Label.TabIndex = 4;
            veli_Tipi__Label.Text = "Veli Tipi :";
            // 
            // telefon__Label
            // 
            telefon__Label.AutoSize = true;
            telefon__Label.Location = new System.Drawing.Point(251, 149);
            telefon__Label.Name = "telefon__Label";
            telefon__Label.Size = new System.Drawing.Size(49, 13);
            telefon__Label.TabIndex = 6;
            telefon__Label.Text = "Telefon :";
            // 
            // veli_Adı_Soyadı__Label
            // 
            veli_Adı_Soyadı__Label.AutoSize = true;
            veli_Adı_Soyadı__Label.Location = new System.Drawing.Point(217, 93);
            veli_Adı_Soyadı__Label.Name = "veli_Adı_Soyadı__Label";
            veli_Adı_Soyadı__Label.Size = new System.Drawing.Size(83, 13);
            veli_Adı_Soyadı__Label.TabIndex = 8;
            veli_Adı_Soyadı__Label.Text = "Veli Adı Soyadı :";
            // 
            // adres__Label
            // 
            adres__Label.AutoSize = true;
            adres__Label.Location = new System.Drawing.Point(42, 123);
            adres__Label.Name = "adres__Label";
            adres__Label.Size = new System.Drawing.Size(40, 13);
            adres__Label.TabIndex = 10;
            adres__Label.Text = "Adres :";
            // 
            // kresDataSet
            // 
            this.kresDataSet.DataSetName = "kresDataSet";
            this.kresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kbs
            // 
            this.kbs.DataMember = "veli";
            this.kbs.DataSource = this.kresDataSet;
            // 
            // veliTableAdapter
            // 
            this.veliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.etkinlikTableAdapter = null;
            this.tableAdapterManager.ogrenciTableAdapter = null;
            this.tableAdapterManager.personelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kres.kresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veliTableAdapter = this.veliTableAdapter;
            this.tableAdapterManager.yemekTableAdapter = null;
            // 
            // veliBindingNavigator
            // 
            this.veliBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.veliBindingNavigator.BindingSource = this.kbs;
            this.veliBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.veliBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.veliBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.veliBindingNavigatorSaveItem});
            this.veliBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.veliBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.veliBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.veliBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.veliBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.veliBindingNavigator.Name = "veliBindingNavigator";
            this.veliBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.veliBindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.veliBindingNavigator.TabIndex = 0;
            this.veliBindingNavigator.Text = "bindingNavigator1";
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
            // veliBindingNavigatorSaveItem
            // 
            this.veliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.veliBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("veliBindingNavigatorSaveItem.Image")));
            this.veliBindingNavigatorSaveItem.Name = "veliBindingNavigatorSaveItem";
            this.veliBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.veliBindingNavigatorSaveItem.Text = "Save Data";
            this.veliBindingNavigatorSaveItem.Click += new System.EventHandler(this.veliBindingNavigatorSaveItem_Click);
            // 
            // veliDataGridView
            // 
            this.veliDataGridView.AllowUserToAddRows = false;
            this.veliDataGridView.AutoGenerateColumns = false;
            this.veliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.veliDataGridView.DataSource = this.kbs;
            this.veliDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.veliDataGridView.Location = new System.Drawing.Point(0, 183);
            this.veliDataGridView.Name = "veliDataGridView";
            this.veliDataGridView.Size = new System.Drawing.Size(573, 248);
            this.veliDataGridView.TabIndex = 1;
            // 
            // öğrenci_TC__TextBox
            // 
            this.öğrenci_TC__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Öğrenci TC :", true));
            this.öğrenci_TC__TextBox.Location = new System.Drawing.Point(88, 94);
            this.öğrenci_TC__TextBox.Name = "öğrenci_TC__TextBox";
            this.öğrenci_TC__TextBox.Size = new System.Drawing.Size(100, 20);
            this.öğrenci_TC__TextBox.TabIndex = 3;
            // 
            // veli_Tipi__TextBox
            // 
            this.veli_Tipi__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Veli Tipi :", true));
            this.veli_Tipi__TextBox.Location = new System.Drawing.Point(306, 120);
            this.veli_Tipi__TextBox.Name = "veli_Tipi__TextBox";
            this.veli_Tipi__TextBox.Size = new System.Drawing.Size(138, 20);
            this.veli_Tipi__TextBox.TabIndex = 5;
            // 
            // telefon__TextBox
            // 
            this.telefon__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Telefon :", true));
            this.telefon__TextBox.Location = new System.Drawing.Point(306, 146);
            this.telefon__TextBox.Name = "telefon__TextBox";
            this.telefon__TextBox.Size = new System.Drawing.Size(138, 20);
            this.telefon__TextBox.TabIndex = 7;
            // 
            // veli_Adı_Soyadı__TextBox
            // 
            this.veli_Adı_Soyadı__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Veli Adı Soyadı :", true));
            this.veli_Adı_Soyadı__TextBox.Location = new System.Drawing.Point(306, 90);
            this.veli_Adı_Soyadı__TextBox.Name = "veli_Adı_Soyadı__TextBox";
            this.veli_Adı_Soyadı__TextBox.Size = new System.Drawing.Size(138, 20);
            this.veli_Adı_Soyadı__TextBox.TabIndex = 9;
            // 
            // adres__TextBox
            // 
            this.adres__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Adres :", true));
            this.adres__TextBox.Location = new System.Drawing.Point(88, 120);
            this.adres__TextBox.Multiline = true;
            this.adres__TextBox.Name = "adres__TextBox";
            this.adres__TextBox.Size = new System.Drawing.Size(156, 46);
            this.adres__TextBox.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 40);
            this.button3.TabIndex = 17;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 47);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adını Girin :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(11, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(216, 14);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Öğrenci TC :";
            this.dataGridViewTextBoxColumn2.HeaderText = "Öğrenci TC :";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Veli Tipi :";
            this.dataGridViewTextBoxColumn3.HeaderText = "Veli Tipi :";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Veli Adı Soyadı :";
            this.dataGridViewTextBoxColumn4.HeaderText = "Veli Adı Soyadı :";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon :";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon :";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adres :";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adres :";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(294, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 27);
            this.button5.TabIndex = 3;
            this.button5.Text = "Öğrencisi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // veli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(adres__Label);
            this.Controls.Add(this.adres__TextBox);
            this.Controls.Add(veli_Adı_Soyadı__Label);
            this.Controls.Add(this.veli_Adı_Soyadı__TextBox);
            this.Controls.Add(telefon__Label);
            this.Controls.Add(this.telefon__TextBox);
            this.Controls.Add(veli_Tipi__Label);
            this.Controls.Add(this.veli_Tipi__TextBox);
            this.Controls.Add(öğrenci_TC__Label);
            this.Controls.Add(this.öğrenci_TC__TextBox);
            this.Controls.Add(this.veliDataGridView);
            this.Controls.Add(this.veliBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "veli";
            this.Text = "Veli ve Adresler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.veli_FormClosing);
            this.Load += new System.EventHandler(this.veli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veliBindingNavigator)).EndInit();
            this.veliBindingNavigator.ResumeLayout(false);
            this.veliBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veliDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kresDataSet kresDataSet;
        private kresDataSetTableAdapters.veliTableAdapter veliTableAdapter;
        private kresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator veliBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton veliBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView veliDataGridView;
        private System.Windows.Forms.TextBox öğrenci_TC__TextBox;
        private System.Windows.Forms.TextBox veli_Tipi__TextBox;
        private System.Windows.Forms.TextBox telefon__TextBox;
        private System.Windows.Forms.TextBox veli_Adı_Soyadı__TextBox;
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
        public System.Windows.Forms.BindingSource kbs;
        private System.Windows.Forms.Button button5;
    }
}