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
    public partial class cartridges : Form
    {
        public cartridges()
        {
            InitializeComponent();
        }

        private void cartrigesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cartrigesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void cartridges_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.cartriges". При необходимости она может быть перемещена или удалена.
            this.cartrigesTableAdapter.Fill(this.baseDataSet.cartriges);

        }
    }
}
