using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Soal0208
    {
        public int Value { get; set; }
        public Soal0208()
        {
            Console.Write("Nilai n : ");
            Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Hasilnya : ");
            Process();
        }
        public void Process()
        {
            for (int i = 0; i <= Value; i++)
            {
                Console.Write($"{Math.Pow(3, i)} \t");
            }
            Console.ReadLine();
        }
    }
}
