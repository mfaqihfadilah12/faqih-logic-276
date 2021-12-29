using System;
using System.Collections.Generic;
using System.Text;

namespace Day02
{
    public class Soal0210
    {
        private int Value { get; set; }
        public Soal0210()
        {
            Console.Write("nilai n : ");
            Value = int.Parse(Console.ReadLine());
            Process();
        }

        public void Process()
        {
            for (int i = 1; i <= Value; i++)
            {
                if ((i - 3) % 3 == 1 && (i - 3) % 6 == 1)
                {
                    Console.Write(" XXX\t");
                }
                else
                {
                    Console.Write($"{Math.Pow(3, i)} \t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
        }
    }
}
