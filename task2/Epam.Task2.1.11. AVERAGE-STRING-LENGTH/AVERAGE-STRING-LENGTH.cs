using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AVERAGE_STRING_LENGTH
{
    class AVERAGE_STRING_LENGTH
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");

            string s;
            s = Console.ReadLine();

            string[] words = s.Split(' ','!','.','?','-');

            
            int answer = 0;

            for (int i = 0; i < words.Length; i++)
            {
                answer += words[i].Length;
            }

            
            Console.WriteLine("Средняя длина слова в введеной строке: " + answer/ words.Length);
        }
    }
}
