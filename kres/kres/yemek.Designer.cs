namespace kres
{
    partial class yemek
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
            System.Windows.Forms.Label tarih__Label;
            System.Windows.Forms.Label kahvaltı__Label;
            System.Windows.Forms.Label öğle__Label;
            System.Windows.Forms.Label akşam__Label;
            System.Windows.Forms.Label saati__Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yemek));
            this.kresDataSet = new kres.kresDataSet();
            this.kbs = new System.Windows.Forms.BindingSource(this.components);
            this.yemekTableAdapter = new kres.kresDataSetTableAdapters.yemekTableAdapter();
            this.tableAdapterManager = new kres.kresDataSetTableAdapters.TableAdapterManager();
            this.yemekDataGridView = new System.Windows.Forms.DataGridView();
            this.tarih__DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kahvaltı__TextBox = new System.Windows.Forms.TextBox();
            this.öğle__TextBox = new System.Windows.Forms.TextBox();
            this.akşam__TextBox = new System.Windows.Forms.TextBox();
            this.saati__TextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.yemekBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.yemekBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tarih__Label = new System.Windows.Forms.Label();
            kahvaltı__Label = new System.Windows.Forms.Label();
            öğle__Label = new System.Windows.Forms.Label();
            akşam__Label = new System.Windows.Forms.Label();
            saati__Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingNavigator)).BeginInit();
            this.yemekBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tarih__Label
            // 
            tarih__Label.AutoSize = true;
            tarih__Label.Location = new System.Drawing.Point(30, 37);
            tarih__Label.Name = "tarih__Label";
            tarih__Label.Size = new System.Drawing.Size(37, 13);
            tarih__Label.TabIndex = 2;
            tarih__Label.Text = "Tarih :";
            // 
            // kahvaltı__Label
            // 
            kahvaltı__Label.AutoSize = true;
            kahvaltı__Label.Location = new System.Drawing.Point(16, 62);
            kahvaltı__Label.Name = "kahvaltı__Label";
            kahvaltı__Label.Size = new System.Drawing.Size(51, 13);
            kahvaltı__Label.TabIndex = 4;
            kahvaltı__Label.Text = "Kahvaltı :";
            // 
            // öğle__Label
            // 
            öğle__Label.AutoSize = true;
            öğle__Label.Location = new System.Drawing.Point(32, 88);
            öğle__Label.Name = "öğle__Label";
            öğle__Label.Size = new System.Drawing.Size(35, 13);
            öğle__Label.TabIndex = 6;
            öğle__Label.Text = "Öğle :";
            // 
            // akşam__Label
            // 
            akşam__Label.AutoSize = true;
            akşam__Label.Location = new System.Drawing.Point(22, 114);
            akşam__Label.Name = "akşam__Label";
            akşam__Label.Size = new System.Drawing.Size(45, 13);
            akşam__Label.TabIndex = 8;
            akşam__Label.Text = "Akşam :";
            // 
            // saati__Label
            // 
            saati__Label.AutoSize = true;
            saati__Label.Location = new System.Drawing.Point(286, 37);
            saati__Label.Name = "saati__Label";
            saati__Label.Size = new System.Drawing.Size(37, 13);
            saati__Label.TabIndex = 10;
            saati__Label.Text = "Saati :";
            // 
            // kresDataSet
            // 
            this.kresDataSet.DataSetName = "kresDataSet";
            this.kresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kbs
            // 
            this.kbs.DataMember = "yemek";
            this.kbs.DataSource = this.kresDataSet;
            // 
            // yemekTableAdapter
            // 
            this.yemekTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.etkinlikTableAdapter = null;
            this.tableAdapterManager.ogrenciTableAdapter = null;
            this.tableAdapterManager.personelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kres.kresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veliTableAdapter = null;
            this.tableAdapterManager.yemekTableAdapter = this.yemekTableAdapter;
            // 
            // yemekDataGridView
            // 
            this.yemekDataGridView.AllowUserToAddRows = false;
            this.yemekDataGridView.AutoGenerateColumns = false;
            this.yemekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yemekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.yemekDataGridView.DataSource = this.kbs;
            this.yemekDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yemekDataGridView.Location = new System.Drawing.Point(0, 151);
            this.yemekDataGridView.Name = "yemekDataGridView";
            this.yemekDataGridView.Size = new System.Drawing.Size(598, 220);
            this.yemekDataGridView.TabIndex = 1;
            // 
            // tarih__DateTimePicker
            // 
            this.tarih__DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kbs, "Tarih :", true));
            this.tarih__DateTimePicker.Location = new System.Drawing.Point(73, 33);
            this.tarih__DateTimePicker.Name = "tarih__DateTimePicker";
            this.tarih__DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tarih__DateTimePicker.TabIndex = 3;
            // 
            // kahvaltı__TextBox
            // 
            this.kahvaltı__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Kahvaltı :", true));
            this.kahvaltı__TextBox.Location = new System.Drawing.Point(73, 59);
            this.kahvaltı__TextBox.Name = "kahvaltı__TextBox";
            this.kahvaltı__TextBox.Size = new System.Drawing.Size(180, 20);
            this.kahvaltı__TextBox.TabIndex = 5;
            // 
            // öğle__TextBox
            // 
            this.öğle__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Öğle :", true));
            this.öğle__TextBox.Location = new System.Drawing.Point(73, 85);
            this.öğle__TextBox.Name = "öğle__TextBox";
            this.öğle__TextBox.Size = new System.Drawing.Size(180, 20);
            this.öğle__TextBox.TabIndex = 7;
            // 
            // akşam__TextBox
            // 
            this.akşam__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Akşam :", true));
            this.akşam__TextBox.Location = new System.Drawing.Point(73, 111);
            this.akşam__TextBox.Name = "akşam__TextBox";
            this.akşam__TextBox.Size = new System.Drawing.Size(180, 20);
            this.akşam__TextBox.TabIndex = 9;
            // 
            // saati__TextBox
            // 
            this.saati__TextBox.Location = new System.Drawing.Point(329, 34);
            this.saati__TextBox.Name = "saati__TextBox";
            this.saati__TextBox.Size = new System.Drawing.Size(100, 20);
            this.saati__TextBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // yemekBindingNavigatorSaveItem
            // 
            this.yemekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yemekBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("yemekBindingNavigatorSaveItem.Image")));
            this.yemekBindingNavigatorSaveItem.Name = "yemekBindingNavigatorSaveItem";
            this.yemekBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.yemekBindingNavigatorSaveItem.Text = "Save Data";
            this.yemekBindingNavigatorSaveItem.Click += new System.EventHandler(this.yemekBindingNavigatorSaveItem_Click);
            // 
            // yemekBindingNavigator
            // 
            this.yemekBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.yemekBindingNavigator.BindingSource = this.kbs;
            this.yemekBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.yemekBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.yemekBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.yemekBindingNavigatorSaveItem});
            this.yemekBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.yemekBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.yemekBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.yemekBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.yemekBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.yemekBindingNavigator.Name = "yemekBindingNavigator";
            this.yemekBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.yemekBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.yemekBindingNavigator.TabIndex = 0;
            this.yemekBindingNavigator.Text = "bindingNavigator1";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tarih :";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tarih :";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kahvaltı :";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kahvaltı :";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Öğle :";
            this.dataGridViewTextBoxColumn4.HeaderText = "Öğle :";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Akşam :";
            this.dataGridViewTextBoxColumn5.HeaderText = "Akşam :";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // yemek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(598, 371);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(saati__Label);
            this.Controls.Add(this.saati__TextBox);
            this.Controls.Add(akşam__Label);
            this.Controls.Add(this.akşam__TextBox);
            this.Controls.Add(öğle__Label);
            this.Controls.Add(this.öğle__TextBox);
            this.Controls.Add(kahvaltı__Label);
            this.Controls.Add(this.kahvaltı__TextBox);
            this.Controls.Add(tarih__Label);
            this.Controls.Add(this.tarih__DateTimePicker);
            this.Controls.Add(this.yemekDataGridView);
            this.Controls.Add(this.yemekBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "yemek";
            this.Text = "Yemek Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yemek_FormClosing);
            this.Load += new System.EventHandler(this.yemek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingNavigator)).EndInit();
            this.yemekBindingNavigator.ResumeLayout(false);
            this.yemekBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kresDataSet kresDataSet;
        private System.Windows.Forms.BindingSource kbs;
        private kresDataSetTableAdapters.yemekTableAdapter yemekTableAdapter;
        private kresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView yemekDataGridView;
        private System.Windows.Forms.DateTimePicker tarih__DateTimePicker;
        private System.Windows.Forms.TextBox kahvaltı__TextBox;
        private System.Windows.Forms.TextBox öğle__TextBox;
        private System.Windows.Forms.TextBox akşam__TextBox;
        private System.Windows.Forms.TextBox saati__TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton yemekBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator yemekBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}