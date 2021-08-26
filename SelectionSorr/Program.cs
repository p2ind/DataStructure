using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayValues = new int[9] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            SelectSort.Sort<int>(ArrayValues);
            Console.WriteLine(string.Join(" | ", ArrayValues));
            Console.ReadKey();


            string s = "";
        }
    }
}
