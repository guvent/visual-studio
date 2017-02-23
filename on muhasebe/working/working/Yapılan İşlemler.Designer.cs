namespace working
{
    partial class Yapılan_İşlemler
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
            System.Windows.Forms.Label belge_NoLabel;
            System.Windows.Forms.Label yapılan_İşlemLabel;
            System.Windows.Forms.Label İşlem_SonucuLabel;
            System.Windows.Forms.Label İşlem_MaliyetiLabel;
            System.Windows.Forms.Label İşlem_TarihiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yapılan_İşlemler));
            this.cagbilDataSet = new working.cagbilDataSet();
            this.yapılanişlemlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yapılanişlemlerTableAdapter = new working.cagbilDataSetTableAdapters.yapılanişlemlerTableAdapter();
            this.tableAdapterManager = new working.cagbilDataSetTableAdapters.TableAdapterManager();
            this.yapılanişlemlerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.yapılanişlemlerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.yapılanişlemlerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.İşlem_TarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.İşlem_MaliyetiTextBox = new System.Windows.Forms.TextBox();
            this.İşlem_SonucuTextBox = new System.Windows.Forms.TextBox();
            this.yapılan_İşlemTextBox = new System.Windows.Forms.TextBox();
            this.belge_NoTextBox = new System.Windows.Forms.TextBox();
            belge_NoLabel = new System.Windows.Forms.Label();
            yapılan_İşlemLabel = new System.Windows.Forms.Label();
            İşlem_SonucuLabel = new System.Windows.Forms.Label();
            İşlem_MaliyetiLabel = new System.Windows.Forms.Label();
            İşlem_TarihiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cagbilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yapılanişlemlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yapılanişlemlerBindingNavigator)).BeginInit();
            this.yapılanişlemlerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yapılanişlemlerDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // belge_NoLabel
            // 
            belge_NoLabel.AutoSize = true;
            belge_NoLabel.Location = new System.Drawing.Point(445, 10);
            belge_NoLabel.Name = "belge_NoLabel";
            belge_NoLabel.Size = new System.Drawing.Size(54, 13);
            belge_NoLabel.TabIndex = 0;
            belge_NoLabel.Text = "Belge No:";
            // 
            // yapılan_İşlemLabel
            // 
            yapılan_İşlemLabel.AutoSize = true;
            yapılan_İşlemLabel.Location = new System.Drawing.Point(7, 39);
            yapılan_İşlemLabel.Name = "yapılan_İşlemLabel";
            yapılan_İşlemLabel.Size = new System.Drawing.Size(72, 13);
            yapılan_İşlemLabel.TabIndex = 2;
            yapılan_İşlemLabel.Text = "Yapılan İşlem:";
            yapılan_İşlemLabel.Click += new System.EventHandler(this.yapılan_İşlemLabel_Click);
            // 
            // İşlem_SonucuLabel
            // 
            İşlem_SonucuLabel.AutoSize = true;
            İşlem_SonucuLabel.Location = new System.Drawing.Point(3, 65);
            İşlem_SonucuLabel.Name = "İşlem_SonucuLabel";
            İşlem_SonucuLabel.Size = new System.Drawing.Size(74, 13);
            İşlem_SonucuLabel.TabIndex = 4;
            İşlem_SonucuLabel.Text = "İşlem Sonucu:";
            // 
            // İşlem_MaliyetiLabel
            // 
            İşlem_MaliyetiLabel.AutoSize = true;
            İşlem_MaliyetiLabel.Location = new System.Drawing.Point(7, 92);
            İşlem_MaliyetiLabel.Name = "İşlem_MaliyetiLabel";
            İşlem_MaliyetiLabel.Size = new System.Drawing.Size(72, 13);
            İşlem_MaliyetiLabel.TabIndex = 6;
            İşlem_MaliyetiLabel.Text = "İşlem Maliyeti:";
            // 
            // İşlem_TarihiLabel
            // 
            İşlem_TarihiLabel.AutoSize = true;
            İşlem_TarihiLabel.Location = new System.Drawing.Point(11, 11);
            İşlem_TarihiLabel.Name = "İşlem_TarihiLabel";
            İşlem_TarihiLabel.Size = new System.Drawing.Size(63, 13);
            İşlem_TarihiLabel.TabIndex = 8;
            İşlem_TarihiLabel.Text = "İşlem Tarihi:";
            // 
            // cagbilDataSet
            // 
            this.cagbilDataSet.DataSetName = "cagbilDataSet";
            this.cagbilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yapılanişlemlerBindingSource
            // 
            this.yapılanişlemlerBindingSource.DataMember = "yapılanişlemler";
            this.yapılanişlemlerBindingSource.DataSource = this.cagbilDataSet;
            // 
            // yapılanişlemlerTableAdapter
            // 
            this.yapılanişlemlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.müşterilerTableAdapter = null;
            this.tableAdapterManager.satılanlarTableAdapter = null;
            this.tableAdapterManager.satisTableAdapter = null;
            this.tableAdapterManager.tamiregelenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = working.cagbilDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ürünlerTableAdapter = null;
            this.tableAdapterManager.yapılanişlemlerTableAdapter = this.yapılanişlemlerTableAdapter;
            // 
            // yapılanişlemlerBindingNavigator
            // 
            this.yapılanişlemlerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.yapılanişlemlerBindingNavigator.BindingSource = this.yapılanişlemlerBindingSource;
            this.yapılanişlemlerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.yapılanişlemlerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.yapılanişlemlerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.yapılanişlemlerBindingNavigatorSaveItem});
            this.yapılanişlemlerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.yapılanişlemlerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.yapılanişlemlerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.yapılanişlemlerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.yapılanişlemlerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.yapılanişlemlerBindingNavigator.Name = "yapılanişlemlerBindingNavigator";
            this.yapılanişlemlerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.yapılanişlemlerBindingNavigator.Size = new System.Drawing.Size(572, 25);
            this.yapılanişlemlerBindingNavigator.TabIndex = 0;
            this.yapılanişlemlerBindingNavigator.Text = "bindingNavigator1";
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
            // yapılanişlemlerBindingNavigatorSaveItem
            // 
            this.yapılanişlemlerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yapılanişlemlerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("yapılanişlemlerBindingNavigatorSaveItem.Image")));
            this.yapılanişlemlerBindingNavigatorSaveItem.Name = "yapılanişlemlerBindingNavigatorSaveItem";
            this.yapılanişlemlerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.yapılanişlemlerBindingNavigatorSaveItem.Text = "Save Data";
            this.yapılanişlemlerBindingNavigatorSaveItem.Click += new System.EventHandler(this.yapılanişlemlerBindingNavigatorSaveItem_Click);
            // 
            // yapılanişlemlerDataGridView
            // 
            this.yapılanişlemlerDataGridView.AllowUserToAddRows = false;
            this.yapılanişlemlerDataGridView.AllowUserToDeleteRows = false;
            this.yapılanişlemlerDataGridView.AutoGenerateColumns = false;
            this.yapılanişlemlerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yapılanişlemlerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.yapılanişlemlerDataGridView.DataSource = this.yapılanişlemlerBindingSource;
            this.yapılanişlemlerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yapılanişlemlerDataGridView.Location = new System.Drawing.Point(0, 160);
            this.yapılanişlemlerDataGridView.Name = "yapılanişlemlerDataGridView";
            this.yapılanişlemlerDataGridView.Size = new System.Drawing.Size(572, 220);
            this.yapılanişlemlerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Belge No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Belge No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "İşlem Tarihi";
            this.dataGridViewTextBoxColumn2.HeaderText = "İşlem Tarihi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Yapılan İşlem";
            this.dataGridViewTextBoxColumn3.HeaderText = "Yapılan İşlem";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "İşlem Sonucu";
            this.dataGridViewTextBoxColumn4.HeaderText = "İşlem Sonucu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "İşlem Maliyeti";
            this.dataGridViewTextBoxColumn5.HeaderText = "İşlem Maliyeti";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(İşlem_TarihiLabel);
            this.panel1.Controls.Add(this.İşlem_TarihiDateTimePicker);
            this.panel1.Controls.Add(İşlem_MaliyetiLabel);
            this.panel1.Controls.Add(this.İşlem_MaliyetiTextBox);
            this.panel1.Controls.Add(İşlem_SonucuLabel);
            this.panel1.Controls.Add(this.İşlem_SonucuTextBox);
            this.panel1.Controls.Add(yapılan_İşlemLabel);
            this.panel1.Controls.Add(this.yapılan_İşlemTextBox);
            this.panel1.Controls.Add(belge_NoLabel);
            this.panel1.Controls.Add(this.belge_NoTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 126);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // İşlem_TarihiDateTimePicker
            // 
            this.İşlem_TarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.yapılanişlemlerBindingSource, "İşlem Tarihi", true));
            this.İşlem_TarihiDateTimePicker.Location = new System.Drawing.Point(85, 7);
            this.İşlem_TarihiDateTimePicker.Name = "İşlem_TarihiDateTimePicker";
            this.İşlem_TarihiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.İşlem_TarihiDateTimePicker.TabIndex = 9;
            // 
            // İşlem_MaliyetiTextBox
            // 
            this.İşlem_MaliyetiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yapılanişlemlerBindingSource, "İşlem Maliyeti", true));
            this.İşlem_MaliyetiTextBox.Location = new System.Drawing.Point(85, 88);
            this.İşlem_MaliyetiTextBox.Name = "İşlem_MaliyetiTextBox";
            this.İşlem_MaliyetiTextBox.Size = new System.Drawing.Size(200, 20);
            this.İşlem_MaliyetiTextBox.TabIndex = 7;
            // 
            // İşlem_SonucuTextBox
            // 
            this.İşlem_SonucuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yapılanişlemlerBindingSource, "İşlem Sonucu", true));
            this.İşlem_SonucuTextBox.Location = new System.Drawing.Point(85, 62);
            this.İşlem_SonucuTextBox.Name = "İşlem_SonucuTextBox";
            this.İşlem_SonucuTextBox.Size = new System.Drawing.Size(200, 20);
            this.İşlem_SonucuTextBox.TabIndex = 5;
            // 
            // yapılan_İşlemTextBox
            // 
            this.yapılan_İşlemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yapılanişlemlerBindingSource, "Yapılan İşlem", true));
            this.yapılan_İşlemTextBox.Location = new System.Drawing.Point(85, 36);
            this.yapılan_İşlemTextBox.Name = "yapılan_İşlemTextBox";
            this.yapılan_İşlemTextBox.Size = new System.Drawing.Size(200, 20);
            this.yapılan_İşlemTextBox.TabIndex = 3;
            this.yapılan_İşlemTextBox.TextChanged += new System.EventHandler(this.yapılan_İşlemTextBox_TextChanged);
            // 
            // belge_NoTextBox
            // 
            this.belge_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yapılanişlemlerBindingSource, "Belge No", true));
            this.belge_NoTextBox.Location = new System.Drawing.Point(424, 33);
            this.belge_NoTextBox.Name = "belge_NoTextBox";
            this.belge_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.belge_NoTextBox.TabIndex = 1;
            // 
            // Yapılan_İşlemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yapılanişlemlerDataGridView);
            this.Controls.Add(this.yapılanişlemlerBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yapılan_İşlemler";
            this.Text = "Yapılan_İşlemler";
            this.Load += new System.EventHandler(this.Yapılan_İşlemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cagbilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yapılanişlemlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yapılanişlemlerBindingNavigator)).EndInit();
            this.yapılanişlemlerBindingNavigator.ResumeLayout(false);
            this.yapılanişlemlerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yapılanişlemlerDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cagbilDataSet cagbilDataSet;
        private System.Windows.Forms.BindingSource yapılanişlemlerBindingSource;
        private cagbilDataSetTableAdapters.yapılanişlemlerTableAdapter yapılanişlemlerTableAdapter;
        private cagbilDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator yapılanişlemlerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton yapılanişlemlerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView yapılanişlemlerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox belge_NoTextBox;
        private System.Windows.Forms.DateTimePicker İşlem_TarihiDateTimePicker;
        private System.Windows.Forms.TextBox İşlem_MaliyetiTextBox;
        private System.Windows.Forms.TextBox İşlem_SonucuTextBox;
        private System.Windows.Forms.TextBox yapılan_İşlemTextBox;
    }
}