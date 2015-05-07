namespace refil_cartridges
{
    partial class users
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baseDataSet = new refil_cartridges.baseDataSet();
            this._nameFIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._nameFIOTableAdapter = new refil_cartridges.baseDataSetTableAdapters._nameFIOTableAdapter();
            this.tableAdapterManager = new refil_cartridges.baseDataSetTableAdapters.TableAdapterManager();
            this._nameFIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._nameFIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._nameFIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nameFIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nameFIOBindingNavigator)).BeginInit();
            this._nameFIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nameFIODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "baseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _nameFIOBindingSource
            // 
            this._nameFIOBindingSource.DataMember = "_nameFIO";
            this._nameFIOBindingSource.DataSource = this.baseDataSet;
            // 
            // _nameFIOTableAdapter
            // 
            this._nameFIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._aktsTableAdapter = null;
            this.tableAdapterManager._nameFIOTableAdapter = this._nameFIOTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cartrigesTableAdapter = null;
            this.tableAdapterManager.printersTableAdapter = null;
            this.tableAdapterManager.tbl_aktsTableAdapter = null;
            this.tableAdapterManager.typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = refil_cartridges.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _nameFIOBindingNavigator
            // 
            this._nameFIOBindingNavigator.AddNewItem = null;
            this._nameFIOBindingNavigator.BindingSource = this._nameFIOBindingSource;
            this._nameFIOBindingNavigator.CountItem = null;
            this._nameFIOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._nameFIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this._nameFIOBindingNavigatorSaveItem});
            this._nameFIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._nameFIOBindingNavigator.MoveFirstItem = null;
            this._nameFIOBindingNavigator.MoveLastItem = null;
            this._nameFIOBindingNavigator.MoveNextItem = null;
            this._nameFIOBindingNavigator.MovePreviousItem = null;
            this._nameFIOBindingNavigator.Name = "_nameFIOBindingNavigator";
            this._nameFIOBindingNavigator.PositionItem = null;
            this._nameFIOBindingNavigator.Size = new System.Drawing.Size(627, 25);
            this._nameFIOBindingNavigator.TabIndex = 0;
            this._nameFIOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::refil_cartridges.Properties.Resources._1413482244_delete;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _nameFIOBindingNavigatorSaveItem
            // 
            this._nameFIOBindingNavigatorSaveItem.Image = global::refil_cartridges.Properties.Resources._1413482323_stock_save_as;
            this._nameFIOBindingNavigatorSaveItem.Name = "_nameFIOBindingNavigatorSaveItem";
            this._nameFIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(124, 22);
            this._nameFIOBindingNavigatorSaveItem.Text = "Сохранить данные";
            this._nameFIOBindingNavigatorSaveItem.Click += new System.EventHandler(this._nameFIOBindingNavigatorSaveItem_Click);
            // 
            // _nameFIODataGridView
            // 
            this._nameFIODataGridView.AllowUserToOrderColumns = true;
            this._nameFIODataGridView.AutoGenerateColumns = false;
            this._nameFIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._nameFIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this._nameFIODataGridView.DataSource = this._nameFIOBindingSource;
            this._nameFIODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameFIODataGridView.Location = new System.Drawing.Point(0, 25);
            this._nameFIODataGridView.Name = "_nameFIODataGridView";
            this._nameFIODataGridView.RowHeadersWidth = 20;
            this._nameFIODataGridView.Size = new System.Drawing.Size(627, 316);
            this._nameFIODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fio_abbr";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО сокращенно";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fio_full";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО полностью";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "post";
            this.dataGridViewTextBoxColumn4.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 341);
            this.Controls.Add(this._nameFIODataGridView);
            this.Controls.Add(this._nameFIOBindingNavigator);
            this.Name = "users";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nameFIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nameFIOBindingNavigator)).EndInit();
            this._nameFIOBindingNavigator.ResumeLayout(false);
            this._nameFIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nameFIODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource _nameFIOBindingSource;
        private baseDataSetTableAdapters._nameFIOTableAdapter _nameFIOTableAdapter;
        private baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator _nameFIOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton _nameFIOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView _nameFIODataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}