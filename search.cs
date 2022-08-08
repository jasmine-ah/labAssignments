using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labEx2.Model;

namespace labEx2
{
    public partial class search : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employees = Class1.findOne(txt_search.Text);
            
              
                if (employees == null)
                {
                    MessageBox.Show("Employee not found");
                }
            else
            {
                MessageBox.Show("Employee found");
                Class1.findOne(employees.Name);
                
                dataGridView1.DataSource = null;
                
            }
            
        }
    }
}
