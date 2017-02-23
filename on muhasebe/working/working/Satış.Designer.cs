namespace working
{
    partial class Satış
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satış));
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satılanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cagbilDataSet = new working.cagbilDataSet();
            this.satisTableAdapter = new working.cagbilDataSetTableAdapters.satisTableAdapter();
            this.tableAdapterManager = new working.cagbilDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.button1 = new System.Windows.Forms.Button();
            this.satılanlarTableAdapter = new working.cagbilDataSetTableAdapters.satılanlarTableAdapter();
            this.satisDataGridView = new System.Windows.Forms.DataGridView();
            this.belgeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.işlemTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.işlemSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriKurumAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriVergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriHesapNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satışYapanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satılanÜrünDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOPLAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriVergiDairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satılanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagbilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "satis";
            this.satisBindingSource.DataSource = this.satılanlarBindingSource;
            // 
            // satılanlarBindingSource
            // 
            this.satılanlarBindingSource.DataSource = this.cagbilDataSet;
            this.satılanlarBindingSource.Position = 0;
            // 
            // cagbilDataSet
            // 
            this.cagbilDataSet.DataSetName = "cagbilDataSet";
            this.cagbilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.müşterilerTableAdapter = null;
            this.tableAdapterManager.satılanlarTableAdapter = null;
            this.tableAdapterManager.satisTableAdapter = this.satisTableAdapter;
            this.tableAdapterManager.tamiregelenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = working.cagbilDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ürünlerTableAdapter = null;
            this.tableAdapterManager.yapılanişlemlerTableAdapter = null;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.satisBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(890, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // satılanlarTableAdapter
            // 
            this.satılanlarTableAdapter.ClearBeforeFill = true;
            // 
            // satisDataGridView
            // 
            this.satisDataGridView.AutoGenerateColumns = false;
            this.satisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.belgeNoDataGridViewTextBoxColumn,
            this.işlemTarihiDataGridViewTextBoxColumn,
            this.işlemSaatiDataGridViewTextBoxColumn,
            this.müşteriKurumAdıDataGridViewTextBoxColumn,
            this.müşteriVergiNoDataGridViewTextBoxColumn,
            this.müşteriHesapNoDataGridViewTextBoxColumn,
            this.satışYapanDataGridViewTextBoxColumn,
            this.satılanÜrünDataGridViewTextBoxColumn,
            this.kDVDataGridViewTextBoxColumn,
            this.tOPLAMDataGridViewTextBoxColumn,
            this.müşteriVergiDairesiDataGridViewTextBoxColumn});
            this.satisDataGridView.DataSource = this.satisBindingSource;
            this.satisDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.satisDataGridView.Location = new System.Drawing.Point(0, 57);
            this.satisDataGridView.Name = "satisDataGridView";
            this.satisDataGridView.Size = new System.Drawing.Size(890, 322);
            this.satisDataGridView.TabIndex = 2;
            // 
            // belgeNoDataGridViewTextBoxColumn
            // 
            this.belgeNoDataGridViewTextBoxColumn.DataPropertyName = "Belge No";
            this.belgeNoDataGridViewTextBoxColumn.HeaderText = "Belge No";
            this.belgeNoDataGridViewTextBoxColumn.Name = "belgeNoDataGridViewTextBoxColumn";
            // 
            // işlemTarihiDataGridViewTextBoxColumn
            // 
            this.işlemTarihiDataGridViewTextBoxColumn.DataPropertyName = "İşlem Tarihi";
            this.işlemTarihiDataGridViewTextBoxColumn.HeaderText = "İşlem Tarihi";
            this.işlemTarihiDataGridViewTextBoxColumn.Name = "işlemTarihiDataGridViewTextBoxColumn";
            // 
            // işlemSaatiDataGridViewTextBoxColumn
            // 
            this.işlemSaatiDataGridViewTextBoxColumn.DataPropertyName = "İşlem Saati";
            this.işlemSaatiDataGridViewTextBoxColumn.HeaderText = "İşlem Saati";
            this.işlemSaatiDataGridViewTextBoxColumn.Name = "işlemSaatiDataGridViewTextBoxColumn";
            // 
            // müşteriKurumAdıDataGridViewTextBoxColumn
            // 
            this.müşteriKurumAdıDataGridViewTextBoxColumn.DataPropertyName = "Müşteri / Kurum Adı";
            this.müşteriKurumAdıDataGridViewTextBoxColumn.HeaderText = "Müşteri / Kurum Adı";
            this.müşteriKurumAdıDataGridViewTextBoxColumn.Name = "müşteriKurumAdıDataGridViewTextBoxColumn";
            // 
            // müşteriVergiNoDataGridViewTextBoxColumn
            // 
            this.müşteriVergiNoDataGridViewTextBoxColumn.DataPropertyName = "Müşteri Vergi No";
            this.müşteriVergiNoDataGridViewTextBoxColumn.HeaderText = "Müşteri Vergi No";
            this.müşteriVergiNoDataGridViewTextBoxColumn.Name = "müşteriVergiNoDataGridViewTextBoxColumn";
            // 
            // müşteriHesapNoDataGridViewTextBoxColumn
            // 
            this.müşteriHesapNoDataGridViewTextBoxColumn.DataPropertyName = "Müşteri Hesap No";
            this.müşteriHesapNoDataGridViewTextBoxColumn.HeaderText = "Müşteri Hesap No";
            this.müşteriHesapNoDataGridViewTextBoxColumn.Name = "müşteriHesapNoDataGridViewTextBoxColumn";
            // 
            // satışYapanDataGridViewTextBoxColumn
            // 
            this.satışYapanDataGridViewTextBoxColumn.DataPropertyName = "Satış Yapan";
            this.satışYapanDataGridViewTextBoxColumn.HeaderText = "Satış Yapan";
            this.satışYapanDataGridViewTextBoxColumn.Name = "satışYapanDataGridViewTextBoxColumn";
            // 
            // satılanÜrünDataGridViewTextBoxColumn
            // 
            this.satılanÜrünDataGridViewTextBoxColumn.DataPropertyName = "Satılan Ürün";
            this.satılanÜrünDataGridViewTextBoxColumn.HeaderText = "Satılan Ürün";
            this.satılanÜrünDataGridViewTextBoxColumn.Name = "satılanÜrünDataGridViewTextBoxColumn";
            // 
            // kDVDataGridViewTextBoxColumn
            // 
            this.kDVDataGridViewTextBoxColumn.DataPropertyName = "KDV";
            this.kDVDataGridViewTextBoxColumn.HeaderText = "KDV";
            this.kDVDataGridViewTextBoxColumn.Name = "kDVDataGridViewTextBoxColumn";
            // 
            // tOPLAMDataGridViewTextBoxColumn
            // 
            this.tOPLAMDataGridViewTextBoxColumn.DataPropertyName = "TOPLAM";
            this.tOPLAMDataGridViewTextBoxColumn.HeaderText = "TOPLAM";
            this.tOPLAMDataGridViewTextBoxColumn.Name = "tOPLAMDataGridViewTextBoxColumn";
            // 
            // müşteriVergiDairesiDataGridViewTextBoxColumn
            // 
            this.müşteriVergiDairesiDataGridViewTextBoxColumn.DataPropertyName = "Müşteri Vergi Dairesi";
            this.müşteriVergiDairesiDataGridViewTextBoxColumn.HeaderText = "Müşteri Vergi Dairesi";
            this.müşteriVergiDairesiDataGridViewTextBoxColumn.Name = "müşteriVergiDairesiDataGridViewTextBoxColumn";
            // 
            // Satış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 379);
            this.Controls.Add(this.satisDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Satış";
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.Satış_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satılanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagbilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource satisBindingSource;
        private cagbilDataSetTableAdapters.satisTableAdapter satisTableAdapter;
        private cagbilDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource satılanlarBindingSource;
        private cagbilDataSetTableAdapters.satılanlarTableAdapter satılanlarTableAdapter;
        private System.Windows.Forms.DataGridView satisDataGridView;
        private cagbilDataSet cagbilDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn işlemTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn işlemSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriKurumAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriVergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriHesapNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satışYapanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satılanÜrünDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOPLAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriVergiDairesiDataGridViewTextBoxColumn;
    }
}