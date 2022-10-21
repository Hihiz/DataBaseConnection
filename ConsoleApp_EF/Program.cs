using ConsoleApp_EF.Models;

namespace ConsoleApp_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user1 = new User { Name = "Tom", Age = 23 };
                User user2 = new User { Name = "Alex", Age = 20 };
                User user3 = new User { Name = "John", Age = 25 };

                db.Add(user1);
                db.Add(user2);
                db.Add(user3);
                db.SaveChanges();

                var users = db.Users.ToList();

                Console.WriteLine("Данные:");
                foreach (User u in users)
                    Console.WriteLine($"{u.Id}. {u.Name} - {u.Age}");
            }
        }
    }
}