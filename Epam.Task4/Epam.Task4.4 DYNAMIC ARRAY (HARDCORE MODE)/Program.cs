using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._4_DYNAMIC_ARRAY__HARDCORE_MODE_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dynamic_array2<int> ar = new Dynamic_array2<int>(new int[] { 1, 2, 3, 4 });

            Console.WriteLine(ar[-2]);
            ar[-2] = 10;
            Console.WriteLine(ar[-2]);

            ar.Capacity = 2;
            foreach (var item in ar)
            {
                Console.Write(item + " ");
            }

            Dynamic_array2<int> ar2;

            ar2 = (Dynamic_array2<int>)ar.Clone();

            ar.Add(12);

            Console.WriteLine();
            foreach (var item in ar)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            foreach (var item in ar2)
            {
                Console.Write(item + " ");
            }

            Dynamic_array2<int> ar7 = new Dynamic_array2<int>();
            ar7.Add(22);
            Console.WriteLine();
            foreach (var item in ar7)
            {
                Console.Write(item + " ");
            }

            int[] mas = ar7.ToArray();
            Console.WriteLine();
            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }

            CycledDynamicArray<int> ar5 = new CycledDynamicArray<int>();
            ar5.AddRange(new int[] { 1, 2, 4 });

            Console.WriteLine("Start cycled. Please enter any key...");
            Console.ReadKey();
            foreach (var item in ar5)
            {
                Console.Write(item + " ");
            }
        }
    }
}
