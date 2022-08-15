using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using labEx2.Model;

namespace labEx2
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
           
            Regex r = new Regex(@"^([^0-9]*)$");


            if (string.IsNullOrEmpty(txt_pid.Text))
            {
                errorProvider1.SetError(txt_pid, "Id is required ");


            }


            if (string.IsNullOrEmpty(txt_price.Text))
            {
                errorProvider1.SetError(txt_price, "The Price is required");
            }

            if (string.IsNullOrEmpty(txt_amount.Text))
            {

                errorProvider1.SetError(txt_amount, "The Amount is required");

            }
            else if (!r.IsMatch(txt_pname.Text))
            {
                errorProvider1.SetError(txt_pname, "Product name should'nt contain numbers");

            }

            else
            {
                try
                {
                    Class2 c = new Class2
                    {
                        pid = (txt_pid.Text),
                        price=int.Parse(txt_price.Text),
                        pname = (txt_pname.Text),
                        amount = int.Parse(txt_amount.Text),
                        WR = radioButton1.Checked,
                        SR = radioButton2.Checked,
                        



                    };
                    c.save();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Class2.getAllProducts();
                    Panel screen = new Panel();
                    screen.Show();
                    this.Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
            
        }

        private void txt_pid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
