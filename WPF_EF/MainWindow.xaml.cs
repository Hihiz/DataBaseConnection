using System.Linq;
using System.Windows;
using WPF_EF.Models;

namespace WPF_EF
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
            using (ApplicationContext db = new ApplicationContext())
            {
                User user1 = new User { Name = "Alex", Age = 20 };
                User user2 = new User { Name = "Tom", Age = 22 };
                User user3 = new User { Name = "John", Age = 24 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);
                db.SaveChanges();

                var user = db.Users.ToList();
                dataGridUser.ItemsSource = user;
            }
        }
    }
}
