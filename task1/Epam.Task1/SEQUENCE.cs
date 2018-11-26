using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.SEQUENCE
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Введите положительное число");

            int N;
            string s = Console.ReadLine();
            N = int.Parse(s);
                         
            for (int i = 1; i < N; i++)
            {
                System.Console.Write(i);
                System.Console.Write(", ");
            }
            System.Console.WriteLine(N); // для того, чтобы запятая не была после последнего числа
        }
    }
}