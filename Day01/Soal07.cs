using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal07
    {
        private int _Value { get; set; }
        public Soal07(int val)
        {
            _Value = val;
        }
        public void Process()
        {
            int g = 2;
            for (int i = 0; i < _Value; i++)
            {
                Console.Write($"{g}\t");
                g *= 2;
            }
            Console.WriteLine("");
            Console.WriteLine("Press Any Key..");
            Console.ReadLine();
        }
    }
}
