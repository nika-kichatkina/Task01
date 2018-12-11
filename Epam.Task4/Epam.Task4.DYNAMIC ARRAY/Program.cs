using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DYNAMIC_ARRAY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DynamicArray<string> array1 = new DynamicArray<string>();

                DynamicArray<string> array2 = new DynamicArray<string>(10);

                int[] array = new int[3] { 1, 2, 3 };
                DynamicArray<int> array3 = new DynamicArray<int>(array);

                DynamicArray<string> array4 = new DynamicArray<string>();
                Console.WriteLine(array4.Capacity);
                Console.WriteLine(array4.Length);
                array4.Add("text1");
                array4.Add("text2");
                array4.Add("text3");
                Console.WriteLine(array4.Capacity);
                Console.WriteLine(array4.Length);
                array4.Add("text6");
                array4.Add("text1");
                array4.Add("text2");
                array4.Add("text3");
                array4.Add("text6");
                array4.Add("text10");
                Console.WriteLine(array4.Capacity);
                Console.WriteLine(array4.Length);

                int[] x1 = new int[] { 1, 2, 3, 23 };
                int[] x2 = new int[] { 1, 0, 12, 23, 33, 99, 100 };
                DynamicArray<int> myClass = new DynamicArray<int>(x1);
                myClass.AddRange(x2);
                array3[2] = 2;

                int[] array6 = new int[] { 1, 2, 3, 23 };
                DynamicArray<int> myClass1 = new DynamicArray<int>(array6);
                myClass.Remove(2);

                int[] array7 = new int[] { 1, 2, 3, 23 };
                DynamicArray<int> myClass2 = new DynamicArray<int>(array7);
                Console.Write(myClass2[2]);

                foreach (var item in myClass)
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
