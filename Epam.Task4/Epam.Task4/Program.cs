using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Lost
{


    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("enter the number of people: ");
            int N = int.Parse(Console.ReadLine());

            var People = new List<int>(N);

            for (int i = 0; i < N; i++)
            {
                People.Add(i + 1);
            }

            GetPeople(People);

            bool flag = false;
            while (People.Count > 1)
            {
                for (int i = 0; i < People.Count; i++)
                {
                    if (flag) People.RemoveAt(i--);
                    flag = !flag;
                }
                GetPeople(People);
            }
            Console.Read();
        }


        public static void GetPeople(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
