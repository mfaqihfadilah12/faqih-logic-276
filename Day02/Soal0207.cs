using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Soal0207
    {
        public int Value { get; set; }
        public Soal0207()
        {
            Console.Write("Nilai n : ");
            Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Hasilnya : ");
            Process();
        }
        public void Process()
        {
            for (int i = 1; i <= Value; i++)
            {
                Console.Write($"{Math.Pow(2, i)} \t");
        
            }
            Console.ReadLine();
        }
    }
}
