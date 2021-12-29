using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal05
    {
        private int _Value { get; set; }
        public Soal05(int val)
        {
            _Value = val;
        }
        public void Process()
        {
            int f = 1;
            for (int i = 1; i <= _Value; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(" *\t");
                }
                else
                {
                    Console.Write($"{f}\t");
                    f += 4;
                }

            }

            Console.WriteLine("");
                Console.WriteLine("Press Any Key..");
                Console.ReadLine();
            }
        }
}
