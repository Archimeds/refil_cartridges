namespace refil_cartridges
{
    partial class printers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.baseDataSet = new refil_cartridges.baseDataSet();
            this.printersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printersTableAdapter = new refil_cartridges.baseDataSetTableAdapters.printersTableAdapter();
            this.tableAdapterManager = new refil_cartridges.baseDataSetTableAdapters.TableAdapterManager();
            this.printersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.printersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingNavigator)).BeginInit();
            this.printersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "baseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printersBindingSource
            // 
            this.printersBindingSource.DataMember = "printers";
            this.printersBindingSource.DataSource = this.baseDataSet;
            // 
            // printersTableAdapter
            // 
            this.printersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._aktsTableAdapter = null;
            this.tableAdapterManager._nameFIOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cartrigesTableAdapter = null;
            this.tableAdapterManager.printersTableAdapter = this.printersTableAdapter;
            this.tableAdapterManager.tbl_aktsTableAdapter = null;
            this.tableAdapterManager.typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = refil_cartridges.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printersBindingNavigator
            // 
            this.printersBindingNavigator.AddNewItem = null;
            this.printersBindingNavigator.BindingSource = this.printersBindingSource;
            this.printersBindingNavigator.CountItem = null;
            this.printersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.printersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.printersBindingNavigatorSaveItem});
            this.printersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.printersBindingNavigator.MoveFirstItem = null;
            this.printersBindingNavigator.MoveLastItem = null;
            this.printersBindingNavigator.MoveNextItem = null;
            this.printersBindingNavigator.MovePreviousItem = null;
            this.printersBindingNavigator.Name = "printersBindingNavigator";
            this.printersBindingNavigator.PositionItem = null;
            this.printersBindingNavigator.Size = new System.Drawing.Size(581, 25);
            this.printersBindingNavigator.TabIndex = 0;
            this.printersBindingNavigator.Text = "bindingNavigator1";
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
            // printersBindingNavigatorSaveItem
            // 
            this.printersBindingNavigatorSaveItem.Image = global::refil_cartridges.Properties.Resources._1413482323_stock_save_as;
            this.printersBindingNavigatorSaveItem.Name = "printersBindingNavigatorSaveItem";
            this.printersBindingNavigatorSaveItem.Size = new System.Drawing.Size(124, 22);
            this.printersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.printersBindingNavigatorSaveItem.Click += new System.EventHandler(this.printersBindingNavigatorSaveItem_Click);
            // 
            // printersDataGridView
            // 
            this.printersDataGridView.AllowUserToOrderColumns = true;
            this.printersDataGridView.AutoGenerateColumns = false;
            this.printersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.printersDataGridView.DataSource = this.printersBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.printersDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.printersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printersDataGridView.Location = new System.Drawing.Point(0, 25);
            this.printersDataGridView.Name = "printersDataGridView";
            this.printersDataGridView.RowHeadersWidth = 20;
            this.printersDataGridView.Size = new System.Drawing.Size(581, 347);
            this.printersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "printer_model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Модель принтера";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "printer_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя принтера";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "invent_number";
            this.dataGridViewTextBoxColumn4.DividerWidth = 1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Инвентарный номер";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // printers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 372);
            this.Controls.Add(this.printersDataGridView);
            this.Controls.Add(this.printersBindingNavigator);
            this.Name = "printers";
            this.Text = "Принтеры";
            this.Load += new System.EventHandler(this.printers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingNavigator)).EndInit();
            this.printersBindingNavigator.ResumeLayout(false);
            this.printersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource printersBindingSource;
        private baseDataSetTableAdapters.printersTableAdapter printersTableAdapter;
        private baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator printersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton printersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView printersDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}