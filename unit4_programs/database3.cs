using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

class Students{
    MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=pnc2078dotnet;UID=root;PASSWORD=;");
    public void AddStudent(string name, int roll, int sem){
        try{
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into students(name,roll,semester) values (@name,@roll,@sem)",conn);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@roll", roll);
            cmd.Parameters.AddWithValue("@sem", sem);
            int num = cmd.ExecuteNonQuery();
            if (num == 1){
                Console.WriteLine("Student Added Successfully");
            }
            else{
                Console.WriteLine("Student Additon Failed");
            }
            conn.Close();
        }catch(MySqlException ex){
            Console.WriteLine("Database Error: "+ex.ToString());
        }catch(Exception ex){
            Console.WriteLine("Error: "+ex.ToString());
        }
    }

    public void ViewStudents(){
        try{
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from students;",conn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if(dt.Rows.Count != 0){
                Console.WriteLine("Name\tRoll\tSemester");
                for(int i=0; i<dt.Rows.Count; i++){
                    string name = dt.Rows[i]["name"].ToString();
                    string roll = dt.Rows[i]["roll"].ToString();
                    string sem = dt.Rows[i]["sem"].ToString();
                    Console.WriteLine("{0}\t{1}\t{2}", name, roll, sem);
                }
            }
            conn.Close();
        }catch(MySqlException ex){
            Console.WriteLine("Database Error: "+ex.ToString());
        }catch(Exception ex){
            Console.WriteLine("Error: "+ex.ToString());
        }
    }

    public void DeleteStudent(){
        try{
            conn.Open();
            Console.WriteLine("Enter the roll no of student: ");
            int roll_no = int.Parse(Console.ReadLine());
            MySqlCommand cmd = new MySqlCommand("delete from students where roll=@roll_no;",conn);
            cmd.Parameters.AddWithValue("@roll_no", roll_no);
            int num = cmd.ExecuteNonQuery();
            if(num == 1){
                Console.WriteLine("Student deleted successfully!");
            }else{
                Console.WriteLine("Student deletion failed!");
            }
            conn.Close();
        }catch(MySqlException ex){
            Console.WriteLine("Database Error: "+ex.ToString());
        }catch(Exception ex){
            Console.WriteLine("Error: "+ex.ToString());
        }
    }

    public void UpdateStudent(){
        try{
            conn.Open();
            Console.WriteLine("Enter the roll no of student to update data: ");
            int roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the semester: ");
            int sem = int.Parse(Console.ReadLine());
            MySqlCommand cmd = new MySqlCommand("update students set name=@name, sem=@sem where roll=@roll_no;",conn);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@roll_no", roll_no);
            cmd.Parameters.AddWithValue("@sem", sem);
            int num = cmd.ExecuteNonQuery();
            if (num == 1){
                Console.WriteLine("Student updated successfully!");
            }
            else{
                Console.WriteLine("Student update failed!");
            }
            conn.Close();
        }catch(MySqlException ex){
            Console.WriteLine("Database Error: "+ex.ToString());
        }catch(Exception ex){
            Console.WriteLine("Error: "+ex.ToString());
        }
    }

}

class Program{
    static void Main(){
        Console.WriteLine("Enter the name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter roll no: ");
        int roll_no = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the semester: ");
        int sem = int.Parse(Console.ReadLine());
        Students std = new Students();
        std.AddStudent(name, roll_no, sem);
        std.ViewStudents();
        std.UpdateStudent();
        std.ViewStudents();
        std.DeleteStudent();
        std.ViewStudents();
    }
}