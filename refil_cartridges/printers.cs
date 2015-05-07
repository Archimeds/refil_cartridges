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
    public partial class printers : Form
    {
        public printers()
        {
            InitializeComponent();
        }

        private void printersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void printers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.printers". При необходимости она может быть перемещена или удалена.
            this.printersTableAdapter.Fill(this.baseDataSet.printers);

        }
               
    }
}
