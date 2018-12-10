using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DYNAMIC_ARRAY
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DynamicArray<string> array1 = new DynamicArray<string>();
                DynamicArray<string> array2 = new DynamicArray<string>(10);
                int[] array = new int[3] { 1,2,3};
                DynamicArray<int> array3 = new DynamicArray<int>(array);
                array1.Add("text");
                array3.AddRange(array);
                array3[2]=2;
                foreach (var item in array3)
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("Eror");
            }
         





        }
    }
}
