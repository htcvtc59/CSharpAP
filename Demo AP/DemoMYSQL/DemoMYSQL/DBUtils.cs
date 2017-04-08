using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMYSQL
{
    class DBUtils
    {
        public static void read()
        {
            String url = "Server=localhost;Uid=root;Pwd=;Database=my_db;";
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            var command = con.CreateCommand();
            command.CommandText = "select * from product";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt16(0);
                String name = reader.GetString("name");
                int price = reader.GetInt32("price");
                Console.WriteLine("id:{0} name:{1} price:{2}", id, name, price);

            }
            Console.ReadLine();
            con.Close();


        }

        public static void write()
        {
            string url = "Server=localhost;Uid=root;Pwd=;Database=my_db;";
            var con = new MySqlConnection(url);
            con.Open();
            var command = con.CreateCommand();
            String sql = "insert into product (name,price) values(@name,@price)";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@name", "Iphone 7");
            command.Parameters.AddWithValue("@price", 1200);
            command.Prepare();
            int rows = command.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("{0} rows inserted ", rows);
            Console.ReadLine();

        }

    }
}
