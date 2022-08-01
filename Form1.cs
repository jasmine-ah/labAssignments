using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labEx2;
using System.Text.RegularExpressions;

namespace labEx2
{
    public partial class Form1 : Form
    {
        

        public Form1( string name)
        {
          
            InitializeComponent();
            label2.Text= name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string checkedItems = "";
            foreach (var item in chk_list.CheckedItems) 
            {
                checkedItems += item.ToString() + " ";
                
            }
            MessageBox.Show(checkedItems);
            Class1 c = new Class1
            {
                Id = (txt_number.Text),

                inventoryNumber = (txt_in.Text),
                ObjectName = txt_on.Text,
                count = (txt_cnt.Text),
                price = (txt_pr.Text),
                isAvailable = isAvailable.Checked,

              
         

        };
            MessageBox.Show("available");
            Regex re = new Regex(@"^[A-Z]{1}^[a-z]$");

            if (txt_on.Text.Length <= 2)
                {
                    MessageBox.Show("Please enter more than 2 character "); 
                
             
                
                    
             if (string.IsNullOrEmpty(txt_on.Text))
            {
                errorProvider1.SetError(txt_on, "Object name is required");
            }

                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
           
                if (string.IsNullOrEmpty(txt_number.Text))
                {
                    errorProvider1.SetError(txt_number, "id is required");
                }
                if (string.IsNullOrEmpty(txt_cnt.Text))
                {
                    errorProvider1.SetError(txt_cnt, "enter count");
                }
                else
            {
                try
                {
                      c.save();
            dgvAdd.DataSource = null;
            dgvAdd.DataSource = Class1.getAllProducts();
              }
                catch (Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
            }      

            
                errorProvider1.Clear();
              
        }

        private void dgvAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void isAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
