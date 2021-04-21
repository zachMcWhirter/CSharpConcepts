using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
    public class Human
    {
        public int Age;
    }

    class Program2
    {
        static void Main(string[] args)
        {

            // Beeps
            {
                Console.Beep(500, 200);
                Console.Beep(500, 200);
            }

            // Value Types:
            // All numeric data types,
            // Boolean, Char, and Date,
            // All structures, even if their members are reference types 
            // Enumerations, since their underlying type is always:
            // SByte, Short, Integer, Long, Byte, UShort, UInteger, or ULong

            // Every structure is a value type, even if it contains reference type members.
            // For this reason, value types such as Char and Integer are implemented by .NET Framework structures.

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("a: {0} b: {1}", a, b);  // a: 10 b: 11

            // Reference Types:
            // String
            // All arrays, even if their elements are value types
            // Class types, such as Form
            // Delegates

            // Since every reference type represents an underlying.NET Framework class,
            // you must use the New Operator keyword when you initialize it.

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine("array1[0]: {0} array2[0]: {1}", array1[0], array2[0]);  // array1: 0 array2: 0







        }
    }
}
