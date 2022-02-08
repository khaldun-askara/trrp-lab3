using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trrp_lab3_thank_god_its_finally_csharp
{
    class Program
    {
        static void ReadingFromSQLite(string dbSource)
        {
            var client = new PSQLServiceReference.PrintToPSQLWebServiceClient();
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = dbSource;

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT cat_id,
                                            cat_name,
                                            color,
                                            breed_id,
                                            breed,
                                            place_id,
                                            place_name,
                                            type,
                                            food_id,
                                            food_name,
                                            price
                                        FROM table_name";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PSQLServiceReference.firstNFLine line = new PSQLServiceReference.firstNFLine();
                        line.cat_id = reader.GetInt32(0);
                        line.cat_name = reader.GetString(1);
                        line.color = reader.GetString(2);
                        line.breed_id = reader.GetInt32(3);
                        line.breed = reader.GetString(4);
                        line.place_id = reader.GetInt32(5);
                        line.place_name = reader.GetString(6);
                        line.type = reader.GetString(7);
                        line.food_id = reader.GetInt32(8);
                        line.food_name = reader.GetString(9);
                        line.price = reader.GetInt32(10);

                        Console.WriteLine(client.printToPostgreSQL(line));
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ReadingFromSQLite(@"C:\Users\Aisen Sousuke\OneDrive\учебное дерьмо\10 трим\тррррррррррррррп\lab 2\lab2\cats_food_and places.sqlite");
            Console.Read();
        }
    }
}
