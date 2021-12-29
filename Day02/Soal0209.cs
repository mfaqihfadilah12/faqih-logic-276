using System;
using System.Collections.Generic;
using System.Text;

namespace Day02
{
    public class Soal0209
    {
        private int Value { get; set; }
        public Soal0209()
        {
            Console.Write("Nilai n : ");
            Value = int.Parse(Console.ReadLine());
            Process();
        }

        public void Process()
        {
            for (int i = 1; i <= Value - 2; i++)
            {
                if ((i - 2) % 2 == 1 && i >= 0)
                {
                    Console.Write(" *\t");
                }
                Console.Write($"{Math.Pow(4, i)} \t");
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
        }
    }
}
