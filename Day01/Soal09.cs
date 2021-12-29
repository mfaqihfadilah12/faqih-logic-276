using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal09
    {
        private int _Value { get; set; }
        public Soal09(int val)
        {
            _Value = val;
        }
        public void Process()
        {
            int e = 4;
            for (int i = 1; i <= _Value; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("*\t");
                }
                else
                {
                    Console.Write($"{e}\t");
                    e *= 4;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press Any Key..");
            Console.ReadLine();
        }
    }
}
