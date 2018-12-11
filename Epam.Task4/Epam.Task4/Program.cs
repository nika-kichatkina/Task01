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
            int n = int.Parse(Console.ReadLine());

            var people = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                people.Add(i + 1);
            }

            GetPeople(people);

            bool flag = false;
            while (people.Count > 1)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (flag)
                    {
                        people.RemoveAt(i--);
                    }

                    flag = !flag;
                }

                GetPeople(people);
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
