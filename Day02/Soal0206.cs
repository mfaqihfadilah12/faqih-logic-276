using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Soal0206
    {
        public int Value { get; set; }
        public Soal0206()
        {
            Console.Write("Nnilai n : ");
            Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Hasilnya : ");
            Process();
        }
        public void Process()
        {
            for (int i = 0; i < Value; i++)
            {

            }
            Console.ReadLine();
        }
    }
}
