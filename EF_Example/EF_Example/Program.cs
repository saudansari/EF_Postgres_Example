using Npgsql;
using System;

namespace EF_Example
{
    class Program
    {

        static void Main(string[] args)
        {
            var connString = "Host=localhost;Username=user;Password=password123;Database=user;Pooling=true;";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("select * from sample_table", conn))
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0) + "," + reader.GetString(1));

            }
        }
    }
}
