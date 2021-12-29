using System;
using System.Collections.Generic;
using System.Text;

namespace Day02
{
    public class Soal0205
    {
        private int Value { get; set; }
        public Soal0205()
        {
            Console.Write("Nilai n : ");
            Value = int.Parse(Console.ReadLine());
            Process();
        }

        public void Process()
        {
            for (int i = 0; i < Value - 2; i++)
            {
                if (i % 2 == 0 && i > 0)
                {
                    Console.Write(" *\t");
                }
                Console.Write($"{i * 4 + 1} \t");
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
        }
    }
}
