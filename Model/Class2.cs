using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
           try
            {
                Class2.Add(this);
                string connectionString = @"Data Source=localhost; Initial catalog=lab;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "insert into products values(" + this.pid + ", '" + this.pname + "',  '" + this.amount + "', '" + this.price + "')";

                SqlCommand cmd = new SqlCommand(Query, connection);

                var result = cmd.ExecuteNonQuery();
                connection.Close();
                int rowsAffected = cmd.ExecuteNonQuery();
                
                if (rowsAffected > 0)
                {

                    MessageBox.Show("Saved Successfully!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }           
public static Class2 findOne(string name){
          try
            {
                string connectionString = @"Data Source=localhost; Initial catalog=lab;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "select * from products;";
                SqlCommand cmd = new SqlCommand(Query, connection);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())

                {
                    Class2 c = new Class2();

                    c.pid = (string)sdr[0];
                    c.pname = (string)sdr[1];
                    c.amount = (string)sdr[2];
                    c.price = (string)sdr[3];

                    temp.Add(c);
                }
                connection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return class2.Find(c=> c.pname==name);
        }


        public static List<Class2> getAllProducts()
        {
           try
            {
                string connectionString = @"Data Source=localhost; Initial catalog=lab;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "select * from products;";
                SqlCommand cmd = new SqlCommand(Query, connection);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())

                {
                    Class2 c = new Class2();

                    c.pid = (string)sdr[0];
                    c.pname = (string)sdr[1];
                    c.amount = (string)sdr[2];
                    c.price = (string)sdr[3];

                    /* int rowsAffected = cmd.ExecuteNonQuery();
                     string r = rowsAffected.ToString();
                     MessageBox.Show("rows affected=" + r);*/

                    temp.Add(c);
                }
                connection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return temp;
            
        }

    

    }
}
