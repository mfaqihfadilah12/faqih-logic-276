using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class PreTask01
    {
        public PreTask01()
        {
            Console.WriteLine("Hello this is from Main Pre-Task 01");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string FullName { get; set; }

        public void SayName()
        {
            FullName = FirstName + LastName;
            Console.WriteLine($"First Name: {FullName}");
            Console.ReadLine();
        }

        public int Age { get; set; }
        // Constructor (ctor)
        public void Module01()
        {
            Module01("dafault value");
        }

        public void Module01(string val)
        {
            Console.WriteLine($"This is from Main->PreTask01->Module01 {val}");
        }

        public void Module01(string val, int val2)
        {
            Console.WriteLine("This is from Main->PreTask01->Module01");
        }

        public void Module01(int val)
        {
            Console.WriteLine("This is from Main->PreTask01->Module01");
        }
    }
}
