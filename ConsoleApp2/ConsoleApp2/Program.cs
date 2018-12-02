//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection())
            {
                //переписал AppConfig файл и добавил туда инфу про мою БД StarWars. Здесь исопользую ее.
                connection.ConnectionString = ConfigurationManager
                                            .ConnectionStrings["StarWarsConnectionStrings"]
                                            .ConnectionString;
                connection.Open();

                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "create table Groups ( id int NOT NULL, name nvarchar(255) NOT NULL );";
                command.ExecuteNonQuery();
            }
        }
    }
}
