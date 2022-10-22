using WindowsForms_EF.Models;
using ApplicationContext = WindowsForms_EF.Models.ApplicationContext;

namespace WindowsForms_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user1 = new User { Name = "Tom", Age = 23 };
                User user2 = new User { Name = "Alex", Age = 21 };
                User user3 = new User { Name = "John", Age = 27 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);
                db.SaveChanges();

                var user = db.Users.ToList();
                dataGridViewUser.DataSource = user;
            }
        }
    }
}