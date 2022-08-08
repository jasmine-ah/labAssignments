using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labEx2.Model
{
    internal class Class1
    {
        public bool isAvailable { get; set; }
        public bool radiobutton1 { get; set; }
        static private List<Class1> class1 = new List<Class1>();
        public string Id { get; set; }
        public bool Name{get; set;}
        public string ObjectName { get; set; }
        public bool Male{get; set;}
        public bool Female{get; set;}
        public bool phone{get; set;}
        public string inventoryNumber { get; set; }

        public string price { get; set; }

        public string count { get; set; }

        public void save()
        {
            class1.Add(this);
            MessageBox.Show("Query executed");
        }
        public static Class1 findOne(string name){
            return class1.Find(c=> c.name==name);
        }


        public static List<Class1> getAllProducts()
        {
            return class1;
        }

    

    }
}
