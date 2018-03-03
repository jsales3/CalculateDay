using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jovon Sales");
            Console.WriteLine("jsales3@kent.edu");

            DateTime myValue = DateTime.Now;

            Console.WriteLine("Enter your Birthdate:");

            string userValue = Console.ReadLine();

            DateTime myBirthday = DateTime.Parse(userValue);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
        }
    }
}
