using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal00
    {
        private int _Value { get; set; }
        public Soal00(int val)
        {
            _Value = val;
        }

        public void Process()
        {
            for (int F = 0; F < _Value; F++)
            {
                Console.Write($"{F}\t");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
