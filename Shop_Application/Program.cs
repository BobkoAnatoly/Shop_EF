using Shop_Application.Models;

namespace Shop_Application
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new ShopDbContext())
            {
                User user = new User { Login = "Jack123", Password = "123",};
                UserProfile userProfile = new UserProfile { FirstName = "Jack", LastName = "Peterson", Age = 19, User = user };

            }
        }
    }
}