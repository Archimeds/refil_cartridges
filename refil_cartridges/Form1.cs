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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            printers frmPrinters = new printers();
            frmPrinters.MdiParent = this;
            frmPrinters.Show();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {            
            Application.Exit();            
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            cartridges frmCartriges = new cartridges();
            frmCartriges.MdiParent = this;
            frmCartriges.Show();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            users frmUsers = new users();
            frmUsers.MdiParent = this;
            frmUsers.Show();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            acts frmActs = new acts();
            frmActs.MdiParent = this;
            frmActs.Show();
        }
                
    }
}
