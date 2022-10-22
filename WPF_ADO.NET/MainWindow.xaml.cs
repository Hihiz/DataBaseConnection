using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace WPF_ADO.NET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CM8LNK7\\SQLEXPRESS;Initial Catalog=UserDataBase;Trusted_Connection=True;";

            string sqlQuery = "SELECT * FROM Users";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string cmd = sqlQuery; // Из какой таблицы нужен вывод 
                SqlCommand createCommand = new SqlCommand(cmd, sqlConnection);
                createCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable(); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                dataGridUser.ItemsSource = dt.DefaultView; // Сам вывод 
                sqlConnection.Close();
            }
        }
    }
}
