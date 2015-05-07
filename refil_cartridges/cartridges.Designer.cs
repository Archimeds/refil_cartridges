namespace refil_cartridges
{
    partial class cartridges
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
            this.cartrigesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartrigesTableAdapter = new refil_cartridges.baseDataSetTableAdapters.cartrigesTableAdapter();
            this.tableAdapterManager = new refil_cartridges.baseDataSetTableAdapters.TableAdapterManager();
            this.cartrigesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartrigesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cartrigesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartrigesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartrigesBindingNavigator)).BeginInit();
            this.cartrigesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartrigesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "baseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartrigesBindingSource
            // 
            this.cartrigesBindingSource.DataMember = "cartriges";
            this.cartrigesBindingSource.DataSource = this.baseDataSet;
            // 
            // cartrigesTableAdapter
            // 
            this.cartrigesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._aktsTableAdapter = null;
            this.tableAdapterManager._nameFIOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cartrigesTableAdapter = this.cartrigesTableAdapter;
            this.tableAdapterManager.printersTableAdapter = null;
            this.tableAdapterManager.tbl_aktsTableAdapter = null;
            this.tableAdapterManager.typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = refil_cartridges.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cartrigesBindingNavigator
            // 
            this.cartrigesBindingNavigator.AddNewItem = null;
            this.cartrigesBindingNavigator.BindingSource = this.cartrigesBindingSource;
            this.cartrigesBindingNavigator.CountItem = null;
            this.cartrigesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cartrigesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.cartrigesBindingNavigatorSaveItem});
            this.cartrigesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cartrigesBindingNavigator.MoveFirstItem = null;
            this.cartrigesBindingNavigator.MoveLastItem = null;
            this.cartrigesBindingNavigator.MoveNextItem = null;
            this.cartrigesBindingNavigator.MovePreviousItem = null;
            this.cartrigesBindingNavigator.Name = "cartrigesBindingNavigator";
            this.cartrigesBindingNavigator.PositionItem = null;
            this.cartrigesBindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.cartrigesBindingNavigator.TabIndex = 0;
            this.cartrigesBindingNavigator.Text = "bindingNavigator1";
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
            // cartrigesBindingNavigatorSaveItem
            // 
            this.cartrigesBindingNavigatorSaveItem.Image = global::refil_cartridges.Properties.Resources._1413482323_stock_save_as;
            this.cartrigesBindingNavigatorSaveItem.Name = "cartrigesBindingNavigatorSaveItem";
            this.cartrigesBindingNavigatorSaveItem.Size = new System.Drawing.Size(124, 22);
            this.cartrigesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cartrigesBindingNavigatorSaveItem.Click += new System.EventHandler(this.cartrigesBindingNavigatorSaveItem_Click);
            // 
            // cartrigesDataGridView
            // 
            this.cartrigesDataGridView.AllowUserToOrderColumns = true;
            this.cartrigesDataGridView.AutoGenerateColumns = false;
            this.cartrigesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartrigesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cartrigesDataGridView.DataSource = this.cartrigesBindingSource;
            this.cartrigesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartrigesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.cartrigesDataGridView.Name = "cartrigesDataGridView";
            this.cartrigesDataGridView.RowHeadersWidth = 20;
            this.cartrigesDataGridView.Size = new System.Drawing.Size(613, 363);
            this.cartrigesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cartridge_model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Модель картриджа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cartridge_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер картриджа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cartridges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 388);
            this.Controls.Add(this.cartrigesDataGridView);
            this.Controls.Add(this.cartrigesBindingNavigator);
            this.Name = "cartridges";
            this.Text = "Картриджы";
            this.Load += new System.EventHandler(this.cartridges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartrigesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartrigesBindingNavigator)).EndInit();
            this.cartrigesBindingNavigator.ResumeLayout(false);
            this.cartrigesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartrigesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource cartrigesBindingSource;
        private baseDataSetTableAdapters.cartrigesTableAdapter cartrigesTableAdapter;
        private baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cartrigesBindingNavigator;
        private System.Windows.Forms.DataGridView cartrigesDataGridView;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cartrigesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}