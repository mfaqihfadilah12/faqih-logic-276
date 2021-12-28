using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal03
    {
        private int _Value { get; set; }
        public Soal03(int val)
        {
            _Value = val;
        }
        public void Process()
        {
            int c = 3;
            for (int i = 0; i < _Value; i++)
            {
                Console.Write($"{c}\t");
                c += 3;
            }
            Console.WriteLine("");
            Console.WriteLine("Press Any Key..");
            Console.ReadLine();
        }
    }
}
