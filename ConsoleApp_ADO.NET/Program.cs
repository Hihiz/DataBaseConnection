using System.Data.SqlClient;

namespace ConsoleApp_ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-CM8LNK7\\SQLEXPRESS;Initial Catalog=UserDataBase;Trusted_Connection=True;";

            string sqlQuery = "SELECT * FROM Users";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                SqlDataReader reader =  command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    string columnName1 = reader.GetName(0);
                    string columnName2 = reader.GetName(1);
                    string columnName3 = reader.GetName(2);

                    Console.WriteLine($"{columnName1}\t{columnName3}\t{columnName2}");

                    while ( reader.Read()) // построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(2);
                        object age = reader.GetValue(1);

                        Console.WriteLine($"{id} \t{name} \t{age}");
                    }
                }
            }
        }
    }
}