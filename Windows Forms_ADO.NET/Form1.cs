using System.Data.SqlClient;
using System.Data;

namespace Windows_Forms_ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CM8LNK7\\SQLEXPRESS;Initial Catalog=UserDataBase;Trusted_Connection=True;";

            string sqlQuery = "SELECT * FROM Users";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string cmd = sqlQuery;
                SqlCommand command = new SqlCommand(cmd, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUser.DataSource = dt;
                sqlConnection.Close();
            }
        }
    }
}