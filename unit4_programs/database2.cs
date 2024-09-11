using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

class Books{
    public void AddBook(string title, int page, int price, string publisher, int edition, string isbn, string category){
        try{
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=test_db;UID=root;PASSWORD=;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into books (title, page, price, publisher, edition, isbn, category) values (@title, @page, @price, @publisher, @edition, @isbn, @category);", conn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@page", page);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@publisher", publisher);
            cmd.Parameters.AddWithValue("@edition", edition);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@category", category);

            int num = cmd.ExecuteNonQuery();
            if(num == 1){
                Console.WriteLine("Book added successfully!");
            }else{
                Console.WriteLine("Book addition failed!");
            }
            conn.Close();
        }catch(MySqlException ex){
            Console.WriteLine("Database Error: "+ex.ToString());
        }catch(Exception ex){
            Console.WriteLine(ex.ToString());
        }
    }

    static void Main(){
        Console.WriteLine("Enter the book title: ");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the number of pages in book: ");
        int page = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the price of book: ");
        int price = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the publisher of book: ");
        string publisher = Console.ReadLine();
        Console.WriteLine("Enter the edition of book: ");
        int edition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the isbn of book: ");
        string isbn = Console.ReadLine();
        Console.WriteLine("Enter the category of book: ");
        string category = Console.ReadLine();

        Books bk = new Books();
        bk.AddBook(title, page, price, publisher, edition, isbn, category);
        
    }
}