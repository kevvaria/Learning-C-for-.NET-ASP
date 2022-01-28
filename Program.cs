using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print to console
            Console.WriteLine("hello world");
            
            // obtain input from console
            Console.Write("Please enter input for test ");
            Console.ReadLine();

            // dealing with variables - boolean
            bool isMale = true;
            Console.WriteLine("Male: " + isMale + "\n\n");

            // dealing with variables - string
            Console.WriteLine("- STRINGS -");
            Console.Write("Please enter a name: ");
            string firstName = Console.ReadLine();
            string lastName = "varia"; 
            Console.WriteLine("Hello, " + firstName.ToUpper() + "!");
            Console.WriteLine("Pattern Matching - " + lastName.Contains("var"));
            Console.WriteLine("Length - Length of first name: " + firstName.Length);
            Console.WriteLine("Indexing - The first letter in the first name is: " + firstName[0]);
            Console.WriteLine("Substring - The substring between position 0 and 3 of the first name is: " + firstName.Substring(0,3) + "\n\n");

            // dealing with variables - numbers (int, float, double, decimal)
            Console.WriteLine("- Numeric Values -");
            int year = 2022;
            Console.WriteLine("The current year is: " + year);
            year++;
            Console.WriteLine("The next year is: " + year);
            Console.WriteLine("Max between two numbers 10 and 20: " + Math.Max(10, 20));
            int num = Convert.ToInt32("45");    //convert numeric values within a string to an int
            Console.Write("Convert (str to int) - Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Convert (str to double) - Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // dealing with variables - array data type
            Console.WriteLine("\n\n- Arrays -");
            int[] luckyNumbers = { 2, 4, 67, 8, 3, 105 };
            string[] names = new string[5];
            names[0] = "keval";
            names[1] = "charlie";
            Console.WriteLine("Second name in the names array: " + names[1] + " has a lucky number " + luckyNumbers[1] + "\n\n");

            // method calls
            Console.WriteLine("- METHODS -");
            greetUser(firstName);
            greetUser(names[1]);
        }

        // method requirements: static/non-static, return type, method name
        static void greetUser(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
