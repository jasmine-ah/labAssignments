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
    public partial class ProductCard : UserControl
    {
        private string _productName;

        public string productid
        {
            get { return _productName; }
            set { _productName = value; label1.Text = value; }
        }
        private string _productname;

        public string productname
        {
            get { return _productname; }
            set { _productname = value; label2.Text = value; }
        }
        private string _amount;

        public string amount
        {
            get { return _amount; ; }
            set { _amount = value;  label3.Text=value ; }
        }
        private string _price;

        public string price
        {
            get { return _price; }
            set { _price = value;   label4.Text=value ; }
        }
        

        public ProductCard()
        {
            InitializeComponent();
        }
    }
}
