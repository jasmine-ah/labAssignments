using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
           try
            {
                class1.Add(this);
                string connectionString = @"Data Source=localhost; Initial catalog=lab;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "insert into employee values(" + this.Id + ", '" + this.Name + "', '" + this.phone + "')";

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
            };



           // class1.Add(this);
            //MessageBox.Show("Query executed");
        }
        public static Class1 findOne(string name){
           try
            {
                string connectionString = @"Data Source=localhost; Initial catalog=lab;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "select * from employee;";
                SqlCommand cmd = new SqlCommand(Query, connection);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())

                {
                    Class1 c = new Class1();

                    c.Id = (string)sdr[0];
                    c.Name = (string)sdr[1];
                    c.phone = (int)sdr[2];

                    temp.Add(c);
                }
                connection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return class1.Find(c=> c.name==name);
        }


        public static List<Class1> getAllProducts()
        {   
             try
            {
                string connectionString = @"Data Source=localhost; Initial catalog=lab;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "select * from employee;";
                SqlCommand cmd = new SqlCommand(Query, connection);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())

                {
                    Class1 c = new Class1();

                    c.Id = (string)sdr[0];
                    c.Name = (string)sdr[1];
                    c.phone = (int)sdr[2];

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
