using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Soal0201
    {
        public int Value { get; set; }
        public Soal0201()
        {
            Console.Write("Nilai n : ");
            Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Hasilnya : ");
            Process();
        }
        public void Process()
        {
            for (int i = 0; i < Value; i++)
            {
                Console.Write($"{i * 2 + 1}\t");
            }
            Console.ReadLine();
        }
    }
}
