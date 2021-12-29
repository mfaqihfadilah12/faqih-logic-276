using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Soal0204
    {
        public int Value { get; set; }
        public Soal0204()
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
                Console.Write($"{i * 4 + 1}\t");
            }
            Console.ReadLine();
        }
    }
}
