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
            Console.WriteLine("Role: Admin.");
            Console.WriteLine();

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
    }
}
