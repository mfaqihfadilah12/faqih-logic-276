using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal02
    {
        private int _Value { get; set; }
        public Soal02(int val)
        {
            _Value = val;
        }
        public void Process()
        {
            int b = 2;
            for (int i = 0; i < _Value; i++)
            {
                Console.Write($"{b}\t");
                b += 2;
            }
            Console.WriteLine("");
            Console.WriteLine("Press Any Key..");
            Console.ReadLine();
        }
    }
}
