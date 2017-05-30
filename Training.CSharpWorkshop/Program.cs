using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharpWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Process();
        }

        public static void Process()
        {
            Console.WriteLine("Welcome to the C# Workshop.");

            Console.WriteLine("Please enter your user name: ");
            var userName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hello " + userName + ".");
            Console.WriteLine(GetRoleMessage(userName));
            Console.WriteLine();

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        public static string GetRoleMessage(string userName)
        {
            string role;

            var repository = new Repository();
            var user = repository.GetUserByName(userName);

            if (user == null)
            {
                role = "None";
            }
            else if (user.Role == RoleEnum.Admin)
            {
                role = "Admin";
            }
            else
            {
                role = "Guest";
            }
            return String.Format("Role: {0}.", role);
        }
    }
}
