using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal04
    {
        private int _Value { get; set; }
        public Soal04(int val)
        {
            _Value = val;
        }
        public void Process()
        {
            int d = 1;
            for (int i = 0; i < _Value; i++)
            {
                Console.Write($"{d}\t");
                d += 4;
            }
            Console.WriteLine("");
            Console.WriteLine("Press Any Key..");
            Console.ReadLine();
        }
    }
}
