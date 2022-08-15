using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labEx2{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin" || textBox1.Text == "user") && textBox2.Text == "admin")
            {

            }
            else {
                MessageBox.Show(" Incorrect!!Try Again");
                    }
           
        }
        private void loginForm_Load(object sender, EventArgs e)
        {

        }


/*        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }*/
    }
}
