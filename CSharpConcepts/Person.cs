﻿using System;

namespace CSharpFundamentals
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}");
        }
    }
}
