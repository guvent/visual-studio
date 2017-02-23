namespace kres
{
    partial class etkinlik
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
            System.Windows.Forms.Label yeri__Label;
            System.Windows.Forms.Label etkinlik_Adı__Label;
            System.Windows.Forms.Label etkinlik_Yeri__Label;
            System.Windows.Forms.Label gerçekleşme_Durumu__Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(etkinlik));
            this.kresDataSet = new kres.kresDataSet();
            this.kbs = new System.Windows.Forms.BindingSource(this.components);
            this.etkinlikTableAdapter = new kres.kresDataSetTableAdapters.etkinlikTableAdapter();
            this.tableAdapterManager = new kres.kresDataSetTableAdapters.TableAdapterManager();
            this.etkinlikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.etkinlikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.etkinlikDataGridView = new System.Windows.Forms.DataGridView();
            this.tarih__DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.yeri__TextBox = new System.Windows.Forms.TextBox();
            this.etkinlik_Adı__TextBox = new System.Windows.Forms.TextBox();
            this.etkinlik_Yeri__TextBox = new System.Windows.Forms.TextBox();
            this.gerçekleşme_Durumu__TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tarih__Label = new System.Windows.Forms.Label();
            yeri__Label = new System.Windows.Forms.Label();
            etkinlik_Adı__Label = new System.Windows.Forms.Label();
            etkinlik_Yeri__Label = new System.Windows.Forms.Label();
            gerçekleşme_Durumu__Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikBindingNavigator)).BeginInit();
            this.etkinlikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tarih__Label
            // 
            tarih__Label.AutoSize = true;
            tarih__Label.Location = new System.Drawing.Point(95, 34);
            tarih__Label.Name = "tarih__Label";
            tarih__Label.Size = new System.Drawing.Size(37, 13);
            tarih__Label.TabIndex = 2;
            tarih__Label.Text = "Tarih :";
            // 
            // yeri__Label
            // 
            yeri__Label.AutoSize = true;
            yeri__Label.Location = new System.Drawing.Point(101, 59);
            yeri__Label.Name = "yeri__Label";
            yeri__Label.Size = new System.Drawing.Size(31, 13);
            yeri__Label.TabIndex = 4;
            yeri__Label.Text = "Yeri :";
            // 
            // etkinlik_Adı__Label
            // 
            etkinlik_Adı__Label.AutoSize = true;
            etkinlik_Adı__Label.Location = new System.Drawing.Point(67, 85);
            etkinlik_Adı__Label.Name = "etkinlik_Adı__Label";
            etkinlik_Adı__Label.Size = new System.Drawing.Size(65, 13);
            etkinlik_Adı__Label.TabIndex = 6;
            etkinlik_Adı__Label.Text = "Etkinlik Adı :";
            // 
            // etkinlik_Yeri__Label
            // 
            etkinlik_Yeri__Label.AutoSize = true;
            etkinlik_Yeri__Label.Location = new System.Drawing.Point(64, 111);
            etkinlik_Yeri__Label.Name = "etkinlik_Yeri__Label";
            etkinlik_Yeri__Label.Size = new System.Drawing.Size(68, 13);
            etkinlik_Yeri__Label.TabIndex = 8;
            etkinlik_Yeri__Label.Text = "Etkinlik Yeri :";
            // 
            // gerçekleşme_Durumu__Label
            // 
            gerçekleşme_Durumu__Label.AutoSize = true;
            gerçekleşme_Durumu__Label.Location = new System.Drawing.Point(17, 137);
            gerçekleşme_Durumu__Label.Name = "gerçekleşme_Durumu__Label";
            gerçekleşme_Durumu__Label.Size = new System.Drawing.Size(115, 13);
            gerçekleşme_Durumu__Label.TabIndex = 10;
            gerçekleşme_Durumu__Label.Text = "Gerçekleşme Durumu :";
            // 
            // kresDataSet
            // 
            this.kresDataSet.DataSetName = "kresDataSet";
            this.kresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kbs
            // 
            this.kbs.DataMember = "etkinlik";
            this.kbs.DataSource = this.kresDataSet;
            // 
            // etkinlikTableAdapter
            // 
            this.etkinlikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.etkinlikTableAdapter = this.etkinlikTableAdapter;
            this.tableAdapterManager.ogrenciTableAdapter = null;
            this.tableAdapterManager.personelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kres.kresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veliTableAdapter = null;
            this.tableAdapterManager.yemekTableAdapter = null;
            // 
            // etkinlikBindingNavigator
            // 
            this.etkinlikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.etkinlikBindingNavigator.BindingSource = this.kbs;
            this.etkinlikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.etkinlikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.etkinlikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.etkinlikBindingNavigatorSaveItem});
            this.etkinlikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.etkinlikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.etkinlikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.etkinlikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.etkinlikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.etkinlikBindingNavigator.Name = "etkinlikBindingNavigator";
            this.etkinlikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.etkinlikBindingNavigator.Size = new System.Drawing.Size(597, 25);
            this.etkinlikBindingNavigator.TabIndex = 0;
            this.etkinlikBindingNavigator.Text = "bindingNavigator1";
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
            // etkinlikBindingNavigatorSaveItem
            // 
            this.etkinlikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.etkinlikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("etkinlikBindingNavigatorSaveItem.Image")));
            this.etkinlikBindingNavigatorSaveItem.Name = "etkinlikBindingNavigatorSaveItem";
            this.etkinlikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.etkinlikBindingNavigatorSaveItem.Text = "Save Data";
            this.etkinlikBindingNavigatorSaveItem.Click += new System.EventHandler(this.etkinlikBindingNavigatorSaveItem_Click);
            // 
            // etkinlikDataGridView
            // 
            this.etkinlikDataGridView.AllowUserToAddRows = false;
            this.etkinlikDataGridView.AutoGenerateColumns = false;
            this.etkinlikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.etkinlikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.etkinlikDataGridView.DataSource = this.kbs;
            this.etkinlikDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.etkinlikDataGridView.Location = new System.Drawing.Point(0, 163);
            this.etkinlikDataGridView.Name = "etkinlikDataGridView";
            this.etkinlikDataGridView.Size = new System.Drawing.Size(597, 291);
            this.etkinlikDataGridView.TabIndex = 1;
            // 
            // tarih__DateTimePicker
            // 
            this.tarih__DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kbs, "Tarih :", true));
            this.tarih__DateTimePicker.Location = new System.Drawing.Point(138, 30);
            this.tarih__DateTimePicker.Name = "tarih__DateTimePicker";
            this.tarih__DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tarih__DateTimePicker.TabIndex = 3;
            // 
            // yeri__TextBox
            // 
            this.yeri__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Yeri :", true));
            this.yeri__TextBox.Location = new System.Drawing.Point(138, 56);
            this.yeri__TextBox.Name = "yeri__TextBox";
            this.yeri__TextBox.Size = new System.Drawing.Size(181, 20);
            this.yeri__TextBox.TabIndex = 5;
            // 
            // etkinlik_Adı__TextBox
            // 
            this.etkinlik_Adı__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Etkinlik Adı :", true));
            this.etkinlik_Adı__TextBox.Location = new System.Drawing.Point(138, 82);
            this.etkinlik_Adı__TextBox.Name = "etkinlik_Adı__TextBox";
            this.etkinlik_Adı__TextBox.Size = new System.Drawing.Size(181, 20);
            this.etkinlik_Adı__TextBox.TabIndex = 7;
            // 
            // etkinlik_Yeri__TextBox
            // 
            this.etkinlik_Yeri__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Etkinlik Yeri :", true));
            this.etkinlik_Yeri__TextBox.Location = new System.Drawing.Point(138, 108);
            this.etkinlik_Yeri__TextBox.Name = "etkinlik_Yeri__TextBox";
            this.etkinlik_Yeri__TextBox.Size = new System.Drawing.Size(181, 20);
            this.etkinlik_Yeri__TextBox.TabIndex = 9;
            // 
            // gerçekleşme_Durumu__TextBox
            // 
            this.gerçekleşme_Durumu__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kbs, "Gerçekleşme Durumu :", true));
            this.gerçekleşme_Durumu__TextBox.Location = new System.Drawing.Point(138, 134);
            this.gerçekleşme_Durumu__TextBox.Name = "gerçekleşme_Durumu__TextBox";
            this.gerçekleşme_Durumu__TextBox.Size = new System.Drawing.Size(181, 20);
            this.gerçekleşme_Durumu__TextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Yeri :";
            this.dataGridViewTextBoxColumn3.HeaderText = "Yeri :";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Etkinlik Adı :";
            this.dataGridViewTextBoxColumn4.HeaderText = "Etkinlik Adı :";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Etkinlik Yeri :";
            this.dataGridViewTextBoxColumn5.HeaderText = "Etkinlik Yeri :";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gerçekleşme Durumu :";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gerçekleşme Durumu :";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Saati :";
            this.dataGridViewTextBoxColumn7.HeaderText = "Saati :";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // etkinlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(597, 454);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(gerçekleşme_Durumu__Label);
            this.Controls.Add(this.gerçekleşme_Durumu__TextBox);
            this.Controls.Add(etkinlik_Yeri__Label);
            this.Controls.Add(this.etkinlik_Yeri__TextBox);
            this.Controls.Add(etkinlik_Adı__Label);
            this.Controls.Add(this.etkinlik_Adı__TextBox);
            this.Controls.Add(yeri__Label);
            this.Controls.Add(this.yeri__TextBox);
            this.Controls.Add(tarih__Label);
            this.Controls.Add(this.tarih__DateTimePicker);
            this.Controls.Add(this.etkinlikDataGridView);
            this.Controls.Add(this.etkinlikBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "etkinlik";
            this.Text = "Etkinlikler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.etkinlik_FormClosing);
            this.Load += new System.EventHandler(this.etkinlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikBindingNavigator)).EndInit();
            this.etkinlikBindingNavigator.ResumeLayout(false);
            this.etkinlikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kresDataSet kresDataSet;
        private System.Windows.Forms.BindingSource kbs;
        private kresDataSetTableAdapters.etkinlikTableAdapter etkinlikTableAdapter;
        private kresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator etkinlikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton etkinlikBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView etkinlikDataGridView;
        private System.Windows.Forms.DateTimePicker tarih__DateTimePicker;
        private System.Windows.Forms.TextBox yeri__TextBox;
        private System.Windows.Forms.TextBox etkinlik_Adı__TextBox;
        private System.Windows.Forms.TextBox etkinlik_Yeri__TextBox;
        private System.Windows.Forms.TextBox gerçekleşme_Durumu__TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}