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
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel3.Top =50;
            panel3.BackColor = Color.Gray;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            panel3.Top = 120;
            panel3.BackColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel3.Top = 185;
            panel3.BackColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {

            panel2.BackColor = Color.Gray;
            panel3.Top = 260;
            panel3.BackColor = Color.Black;
        }

        private void panel_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Class2.getAllProducts())
            {
                ProductCard pc = new ProductCard();
                pc.productname = item.pname;
                pc.productid = item.pid;
                pc.amount = item.amount;
                pc.price = item.price;
                 pc.Click += (object o, EventArgs e2) =>
                {

                    newForm2 screen = new newForm2(item.pname, item.pid, item.amount, item.price);
                    screen.Show();
                    this.Hide();
                    
                };
                flowLayoutPanel1.Controls.Add(pc);
            }
        }
    }
}
