using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.SIMPLE
{
    class SIMPLE
    {
        public static bool prime(int a)
        {
            if (a == 1) return false;

            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Ведите положительное целое число");
            string s = System.Console.ReadLine();
            int N = int.Parse(s);

            bool questions = prime(N);
            if (questions == true) System.Console.WriteLine("Yes");
            if (questions == false) System.Console.WriteLine("No");


        }
    }
}
