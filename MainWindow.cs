using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labEx2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();


            }


            Form1 form1 = new Form1();
            
            form1.MdiParent = this;
            form1.Show();
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();


            }


            search s1 = new search();

            s1.MdiParent = this;
            s1.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();


            }


            addProduct add = new addProduct();

            add.MdiParent = this;
            add.Show();
        }
        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();


            }


            Panel add = new Panel();

            add.MdiParent = this;
            add.Show();
        }
    }
}
