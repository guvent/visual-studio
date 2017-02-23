namespace kres
{
    partial class personel
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
            System.Windows.Forms.Label tC_Kimlik__Label;
            System.Windows.Forms.Label adı__Label;
            System.Windows.Forms.Label soyadı__Label;
            System.Windows.Forms.Label telefon__Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            this.kresDataSet = new kres.kresDataSet();
            this.kbs = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new kres.kresDataSetTableAdapters.personelTableAdapter();
            this.tableAdapterManager = new kres.kresDataSetTableAdapters.TableAdapterManager();
            this.personelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.personelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personelDataGridView = new System.Windows.Forms.DataGridView();
            this.tC_Kimlik__TextBox = new System.Windows.Forms.TextBox();
            this.adı__TextBox = new System.Windows.Forms.TextBox();
            this.soyadı__TextBox = new System.Windows.Forms.TextBox();
            this.telefon__TextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tC_Kimlik__Label = new System.Windows.Forms.Label();
            adı__Label = new System.Windows.Forms.Label();
            soyadı__Label = new System.Windows.Forms.Label();
            telefon__Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingNavigator)).BeginInit();
            this.personelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tC_Kimlik__Label
            // 
            tC_Kimlik__Label.AutoSize = true;
            tC_Kimlik__Label.Location = new System.Drawing.Point(14, 36);
            tC_Kimlik__Label.Name = "tC_Kimlik__Label";
            tC_Kimlik__Label.Size = new System.Drawing.Size(57, 13);
            tC_Kimlik__Label.TabIndex = 2;
            tC_Kimlik__Label.Text = "TC Kimlik :";
            // 
            // adı__Label
            // 
            adı__Label.AutoSize = true;
            adı__Label.Location = new System.Drawing.Point(43, 62);
            adı__Label.Name = "adı__Label";
            adı__Label.Size = new System.Drawing.Size(28, 13);
            adı__Label.TabIndex = 4;
            adı__Label.Text = "Adı :";
            // 
            // soyadı__Label
            // 
            soyadı__Label.AutoSize = true;
            soyadı__Label.Location = new System.Drawing.Point(213, 62);
            soyadı__Label.Name = "soyadı__Label";
            soyadı__Label.Size = new System.Drawing.Size(45, 13);
            soyadı__Label.TabIndex = 6;
            soyadı__Label.Text = "Soyadı :";
            // 
            // telefon__Label
            // 
            telefon__Label.AutoSize = true;
            telefon__Label.Location = new System.Drawing.Point(209, 36);
            telefon__Label.Name = "telefon__Label";
            telefon__Label.Size = new System.Drawing.Size(49, 13);
            telefon__Label.TabIndex = 8;
            telefon__Label.Text = "Telefon :";
            // 
            // kresDataSet
            // 
            this.kresDataSet.DataSetName = "kresDataSet";
            this.kresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kbs
            // 
            this.kbs.DataMember = "personel";
            this.kbs.DataSource = this.kresDataSet;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.etkinlikTableAdapter = null;
            this.tableAdapterManager.ogrenciTableAdapter = null;
            this.tableAdapterManager.personelTableAdapter = this.personelTableAdapter;
            this.tableAdapterManager.UpdateOrder = kres.kresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veliTableAdapter = null;
            this.tableAdapterManager.yemekTableAdapter = null;
            // 
            // personelBindingNavigator
            // 
            this.personelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personelBindingNavigator.BindingSource = this.kbs;
            this.personelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personelBindingNavigatorSaveItem});
            this.personelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personelBindingNavigator.Name = "personelBindingNavigator";
            this.personelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personelBindingNavigator.Size = new System.Drawing.Size(600, 25);
            this.personelBindingNavigator.TabIndex = 0;
            this.personelBindingNavigator.Text = "bindingNavigator1";
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
            // personelBindingNavigatorSaveItem
            // 
            this.personelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personelBindingNavigatorSaveItem.Image")));
            this.personelBindingNavigatorSaveItem.Name = "personelBindingNavigatorSaveItem";
            this.personelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personelBindingNavigatorSaveItem.Text = "Save Data";
            this.personelBindingNavigatorSaveItem.Click += new System.EventHandler(this.personelBindingNavigatorSaveItem_Click);
            // 
            // personelDataGridView
            // 
            this.personelDataGridView.AllowUserToAddRows = false;
            this.personelDataGridView.AutoGenerateColumns = false;
            this.personelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personelDataGridView.DataSource = this.kbs;
            this.personelDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personelDataGridView.Location = new System.Drawing.Point(0, 94);
            this.personelDataGridView.Name = "personelDataGridView";
            this.personelDataGridView.Size = new System.Drawing.Size(600, 219);
            this.personelDataGridView.TabIndex = 1;
            // 
            // tC_Kimlik__TextBox
            // 
            this.tC_Kimlik__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "TC Kimlik :", true));
            this.tC_Kimlik__TextBox.Location = new System.Drawing.Point(77, 33);
            this.tC_Kimlik__TextBox.Name = "tC_Kimlik__TextBox";
            this.tC_Kimlik__TextBox.Size = new System.Drawing.Size(127, 20);
            this.tC_Kimlik__TextBox.TabIndex = 3;
            // 
            // adı__TextBox
            // 
            this.adı__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Adı :", true));
            this.adı__TextBox.Location = new System.Drawing.Point(77, 59);
            this.adı__TextBox.Name = "adı__TextBox";
            this.adı__TextBox.Size = new System.Drawing.Size(127, 20);
            this.adı__TextBox.TabIndex = 5;
            // 
            // soyadı__TextBox
            // 
            this.soyadı__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Soyadı :", true));
            this.soyadı__TextBox.Location = new System.Drawing.Point(264, 59);
            this.soyadı__TextBox.Name = "soyadı__TextBox";
            this.soyadı__TextBox.Size = new System.Drawing.Size(127, 20);
            this.soyadı__TextBox.TabIndex = 7;
            // 
            // telefon__TextBox
            // 
            this.telefon__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Telefon :", true));
            this.telefon__TextBox.Location = new System.Drawing.Point(264, 33);
            this.telefon__TextBox.Name = "telefon__TextBox";
            this.telefon__TextBox.Size = new System.Drawing.Size(127, 20);
            this.telefon__TextBox.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TC Kimlik :";
            this.dataGridViewTextBoxColumn2.HeaderText = "TC Kimlik :";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon :";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon :";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 313);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(telefon__Label);
            this.Controls.Add(this.telefon__TextBox);
            this.Controls.Add(soyadı__Label);
            this.Controls.Add(this.soyadı__TextBox);
            this.Controls.Add(adı__Label);
            this.Controls.Add(this.adı__TextBox);
            this.Controls.Add(tC_Kimlik__Label);
            this.Controls.Add(this.tC_Kimlik__TextBox);
            this.Controls.Add(this.personelDataGridView);
            this.Controls.Add(this.personelBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "personel";
            this.Text = "Personel Listesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.personel_FormClosing);
            this.Load += new System.EventHandler(this.personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingNavigator)).EndInit();
            this.personelBindingNavigator.ResumeLayout(false);
            this.personelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kresDataSet kresDataSet;
        private System.Windows.Forms.BindingSource kbs;
        private kresDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private kresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton personelBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView personelDataGridView;
        private System.Windows.Forms.TextBox tC_Kimlik__TextBox;
        private System.Windows.Forms.TextBox adı__TextBox;
        private System.Windows.Forms.TextBox soyadı__TextBox;
        private System.Windows.Forms.TextBox telefon__TextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}