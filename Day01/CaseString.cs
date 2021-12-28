using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class CaseString
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string Value { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public CaseString(string value)
        {
            Value = value;
        }

        public CaseString(string val1, string val2)
        {
            FirstName = val1;
            LastName = val2;
        }

        public void PrintValue()
        {
            Console.WriteLine($"Value is {Value}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name  : {FirstName} {LastName}");
            Console.WriteLine($"Full Name Getter : {FullName}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
