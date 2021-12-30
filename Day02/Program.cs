using System;

namespace Day02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public Program()
        {
            Console.WriteLine("Day 02");
            bool loop = true;
            while (true)
            {
                Console.Write("Masukkan nomor soal : ");
                int soal = int.Parse(Console.ReadLine());
                switch (soal)
                {
                    case 1:
                        Soal0201 soal0201 = new Soal0201();
                        break;
                    case 2:
                        Soal0202 soal0202 = new Soal0202();
                        //Console.WriteLine("Soal0202 ada disini");
                        break;
                    case 3:
                        Soal0203 soal0203 = new Soal0203();
                        break;
                    case 4:
                        Soal0204 soal0204 = new Soal0204();
                        break;
                    case 5:
                        Soal0205 soal0205 = new Soal0205();
                        break;
                    case 6:
                        Soal0206 soal0206 = new Soal0206();
                        break;
                    case 7:
                        Soal0207 soal0207 = new Soal0207();
                        break;
                    case 8:
                        Soal0208 soal0208 = new Soal0208();
                        break;
                    case 9:
                        Soal0209 soal0209 = new Soal0209();
                        break;
                    case 10:
                        Soal0210 soal0210 = new Soal0210();
                        break;
                    //case 11:
                    //    Soal02LatihanArray soal2LatihanArray = new Soal02LatihanArray();
                    //    break;
                    case 11:
                        Soal0201Array soal0201Array = new Soal0201Array();
                        break;
                    case 12:
                        Soal0202Array soal0202Array = new Soal0202Array();
                        break;
                    case 13:
                        Soal0203Array soal0203Array = new Soal0203Array();
                        break;
                    case 14:
                        Soal0204Array soal0204Array = new Soal0204Array();
                        break;
                    case 15:
                        Soal0205Array soal0205Array = new Soal0205Array();
                        break:
                    default:
                        break;
                }
                Console.Write("Apakah sudah selesai Day 02? [Y/T]");
                string jawab= Console.ReadLine();
                //if (jawab.ToUpper() == "T")
                //{
                //    Loop = true;
                //}
                //else
                //    Loop = false;
                //simpelnya (toupper itu agar kalo nulis t kecil menjadi T besar kalo nulis T besar ya tetap T besar)
                loop = jawab.ToUpper() == "t";
            }
        }
    }
}
