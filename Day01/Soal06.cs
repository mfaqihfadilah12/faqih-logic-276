using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal06
    {
        private int _Value { get; set; }
        public Soal06(int val)
        {
            _Value = val;
        }

        public void Process()
        {
            int f = 1;
            for (int i = 0; i < _Value; i++)
            {
                if (f % 3 == 0)
                {
                    Console.Write(" *\t");
                }
                else
                {
                    Console.Write($"{f}\t");
                }
                f += 4;

            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
        }
    }
}
