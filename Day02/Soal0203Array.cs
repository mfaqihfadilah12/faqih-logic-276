using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility;

namespace Day02
{
    public class Soal0203Array : BaseProperties
    {
        public Soal0203Array()
        {
            Console.Write("Masukkan nilai n1 : ");
            Cols = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai n2 : ");
            Value = int.Parse(Console.ReadLine());
            Rows = 2;
            SetValue();
            Process();
            Print();
            //Console.WriteLine($"Array[{Array2d.GetLength(0)},{Array2d.GetLength(1)}]");
            //Console.WriteLine("Press any key ...");
            //Console.ReadLine();
        }
        public void Process()
        {
            for (int row = 0; row < Array2d.GetLength(0); row++)
            {
                for (int col = 0; col < Array2d.GetLength(1); col++)
                {
                    if (row == 0)
                        Array2d[row, col] = col.ToString();
                    else
                        Array2d[row, col] = (Math.Pow(3, col^2)).ToString();

                }
            }
        }
        public void Print()
        {
            for (int row = 0; row < Array2d.GetLength(0); row++)
            {
                for (int col = 0; col < Array2d.GetLength(1); col++)
                {
                    //pindah kolom
                    Console.Write(Array2d[row, col] + "\t");
                }
                //Pindah baris
                Console.WriteLine("\n");
            }
        }
    }
}
