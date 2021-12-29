using Day01;
using Day02;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello batch 276!");


            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal0201 soal0201 = new Soal0201(n);
            soal0201.Process();*/

            bool Loop = true;

            while (Loop)
            {
                Console.Write("Masukkan angka hari : ");
                int hari = int.Parse(Console.ReadLine());
                switch (hari)
                {
                    case 1:
                        Day01.Program program1 = new Day01.Program();
                        break;
                    case 2:
                        Day02.Program program2 = new Day02.Program();
                        break;
                    default:
                        break;

                }
                Console.WriteLine(" Apakah kita masih ingin berlanjut ? [Y/T]");
                string jawab = Console.ReadLine();
                if ( jawab == "Y")
                {
                    Loop = true;
                } else {
                    Loop = false;
                }

            }

            //soal00
            //Console.Write("Input n : ");
            /*int n = int.Parse(Console.ReadLine());
            Soal00 soal00 = new Soal00(n);
            soal00.Process();*/

            //soal01
            /*Console.Write("Input f : ");
            int f = int.Parse(Console.ReadLine());
            Soal01 soal01 = new Soal01(n);
            soal01.Process();*/

            //soal02
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal02 soal02 = new Soal02(n);
            soal02.Process();*/

            //soal03
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal03 soal03 = new Soal03(n);
            soal03.Process();*/

            //soal04
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal04 soal04 = new Soal04(n);
            soal04.Process();*/

            //soal05
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal05 soal05 = new Soal05(n);
            soal05.Process();*/

            //soal06
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal06 soal06 = new Soal06(n);
            soal06.Process();*/

            //soal07
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal07 soal07 = new Soal07(n);
            soal07.Process();*/

            //soal08
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal08 soal08 = new Soal08(n);
            soal08.Process();*/

            //soal09
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal09 soal09 = new Soal09(n);
            soal09.Process();*/

            //soal10
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal10 soal10 = new Soal10(n);
            soal10.Process();*/

            //days02

            //soal1
            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal1 soal1 = new Soal1(n);
            soal1.Process();*/

            /*Console.Write("Input n : ");
            int n = int.Parse(Console.ReadLine());
            Soal10 soal10 = new Soal10(n);
            soal10.Process();*/

            /*Console.Write("Input your firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Input your lastname: ");
            string lastname = Console.ReadLine();
            CaseString caseString = new CaseString(firstname, lastname);
            caseString.PrintFullName();

            Console.WriteLine($"FullName Main: {caseString.FullName1}");
            Console.Write("Press Any Key.. ");
            Console.ReadLine();*/

            //Console.WriteLine("Press any key to Continue..");
            //Console.ReadLine();
            //Console.Write("Siapa Nama Anda? : ");
            //String Nama = Console.ReadLine();
            //Console.WriteLine("Nama Saya adalah : " + Nama);
            //Console.WriteLine("Lanjut");
            //Console.ReadLine();

            //PreTask01b preTask01b = new PreTask01b();
            //preTask01b.Kata1 = "Muhammad";
            //preTask01b.Kata2 = "Faqih";
            //preTask01b.Kata3 = "Fadilah";
            //preTask01b.Kata4 = "";
            //preTask01b.SayName();
            //Console.WriteLine("Lanjut");
            //Console.ReadLine();

            //preTask01b.TahunSekarang = 2021;
            //preTask01b.TahunLahir = 1999;
            //preTask01b.UmurSaya();
            //Console.ReadLine();

            //Console.Write("Tahun Sekarang : ");
            //string TahunSekarang = Console.ReadLine();
            //Console.Write("Tahun Lahir : ");
            //string TahunLahir = Console.ReadLine();

            //preTask01b.Module01("OK");
            Console.WriteLine("Press any key to Continue..");
            Console.ReadLine();
        }
    }
}
