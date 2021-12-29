using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Soal0202
    {
        public int Value { get; set; }
        public Soal0202()
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
                Console.Write($"{i * 2 + 2}\t");
            }
            Console.ReadLine();
        }
        }
}
