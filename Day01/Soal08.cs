using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class Soal08
    {
        private int _Value { get; set; }
        public Soal08(int val)
        {
            _Value = val;
        }
        public void Process()
        {
            int h = 3;
            for (int i = 0; i < _Value; i++)
            {
                Console.Write($"{h}\t");
                h *= 3;
            }
            Console.WriteLine("");
            Console.WriteLine("Press Any Key..");
            Console.ReadLine();
        }
    }
}
