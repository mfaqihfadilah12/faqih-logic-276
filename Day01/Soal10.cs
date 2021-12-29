using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal10
    {
        private int _Value { get; set; }
        public Soal10(int val)
        {
            _Value = val;
        }
        public void Process()
        {
            int e = 3;
            for (int i = 1; i <= _Value; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("XXX\t");
                }
                else
                {
                    Console.Write($"{e}\t");
                    e *= 3;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press Any Key..");
            Console.ReadLine();
        }
    }
}
