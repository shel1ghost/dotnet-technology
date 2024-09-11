using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PNC2078Unit4
{
    internal class DatabaseExample
    {
        public void AddData(string n, int r, int s)
        {
            try
            {
               //  string ConnectionString = "SERVER=localhost;DATABASE=pkmc2076DOTNET;UID=root;PASSWORD=;";
                // MySqlConnection mySqlConnection = null;
                MySqlConnection mySqlConnection = new MySqlConnection("SERVER=localhost;DATABASE=pnc2078dotnet;UID=root;PASSWORD=;");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("insert into students(name,roll,semester) values (@name,@roll,@sem)",mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@name",n);
                mySqlCommand.Parameters.AddWithValue("@roll", r);
                mySqlCommand.Parameters.AddWithValue("@sem", s);
                int num = mySqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    Console.WriteLine("Student Added Successfully");
                }
                else
                {
                    Console.WriteLine("Student Additon Failed");
                }
                mySqlConnection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.ToString()) ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } 
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name \t");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Roll \t");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter semester \t");
            int sem = int.Parse(Console.ReadLine());
            DatabaseExample databaseExample = new DatabaseExample();
            databaseExample.AddData(name,roll,sem);
            Console.ReadKey();
        }

    }
}

