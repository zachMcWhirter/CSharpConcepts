using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            // Beeps
            {
                Console.Beep(500, 200);
                Console.Beep(500, 200);
            }

            // Person
            var jj = new Person();
            jj.FirstName = "JJ";
            jj.LastName = "Jameson";
            jj.Introduce(); // Hello, my name is JJ Jameson

            // Calculator
            Calculator calculator = new Calculator();
            var result = calculator.Add(5, 7);
            Console.WriteLine(result); // 12

            // Arrays
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]); // 1
            Console.WriteLine(numbers[1]); // 0
            Console.WriteLine(numbers[2]); // 0

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]); // True
            Console.WriteLine(flags[1]); // False
            Console.WriteLine(flags[2]); // False

            // Strings
            // string, var, and String all produce the same result
            string firstName = "The";
            var middleName = "Big";
            String lastName = "Lebowski";
            Console.WriteLine($"{firstName} {middleName} {lastName}"); // The Big Lebowski

            var fullName = string.Format("My name is {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine(fullName); // My name is The Big Lebowski

            var names = new string[3] { "Liam", "Owen", "Jameson" };
            var formattedNames = string.Join(',', names);
            Console.WriteLine(formattedNames); // Liam,Owen,Jameson

            // Enums
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);  // 3

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // Express
            Console.WriteLine(method.ToString()); // Express

            var methodName = "Express";

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod); // Express

        }
        public enum ShippingMethod
        {
            Standard = 1,
            TwoDay = 2,
            Express = 3
        }

    }
}

