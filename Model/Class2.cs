using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labEx2.Model
{
    internal class Class2
    {
        static private List<Class2> class2=new List<Class2>();
        public string pid{get; set;}
          public string pname{get; set;}
            public string amount{get; set;}
              public string price{get; set;}
                public string WR{get; set;}
                  public string SR{get; set;}

       public void save()
        {
            class2.Add(this);
            MessageBox.Show("Query executed");
        }           
public static Class2 findOne(string name){
            return class2.Find(c=> c.pname==name);
        }


        public static List<Class2> getAllProducts()
        {
            return class2;
        }

    

    }
}
