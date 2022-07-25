﻿using lectEx.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lectEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorPro1.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(tbNum.Text))
            {
                errorPro1.SetError(tbNum, "Number is required");
            }
            else if (string.IsNullOrEmpty(tbInvNum.Text))
            {
                errorPro1.SetError(tbInvNum, "Inventory Number is required");
            }
            else if (string.IsNullOrEmpty(tbObjName.Text))
            {
                errorPro1.SetError(tbObjName, "Object name is required");
            }
            else if (string.IsNullOrEmpty(tbCount.Text))
            {
                errorPro1.SetError(tbCount, "Count is required");
            }
            else if (string.IsNullOrEmpty(tbPrice.Text))
            {
                errorPro1.SetError(tbPrice, "Price is required");
            }
            else if (!r.IsMatch(tbObjName.Text))
            {
                errorPro1.SetError(tbObjName, "String should not have numbers.");
            }
            else
            {
                try
                {
                    Project p = new Project
                    {
                        Number = int.Parse(tbNum.Text),
                        Date = dateTimePicker1.Text,
                        Inv_Num = int.Parse(tbInvNum.Text),
                        Obj_name = tbObjName.Text,
                        Count = int.Parse(tbCount.Text),
                        Price = double.Parse(tbPrice.Text)
                    };
                    p.save();
                    DGV.DataSource = null;
                    DGV.DataSource = Project.GetAllProducts();
                }
                catch (Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
            }        
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
