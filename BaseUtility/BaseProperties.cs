using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUtility
{
    public class BaseProperties
    {
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int Value { get; set; }
        public string[,] Array2d
        {
            //get
            //{
            //    //string[index 0, index 1];
            //    return new string[Rows, Cols];
            //}
            //set { }
            get;
            set;
        }

        public void SetValue()
        {
            Array2d = new string[Rows, Cols];
        }

        public void ShowValues()
        {
            Console.WriteLine($"Rows: {Rows}, Cols : {Cols}");
        }
    }
}
