using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace refil_cartridges
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void _nameFIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._nameFIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet._nameFIO". При необходимости она может быть перемещена или удалена.
            this._nameFIOTableAdapter.Fill(this.baseDataSet._nameFIO);

        }
    }
}
