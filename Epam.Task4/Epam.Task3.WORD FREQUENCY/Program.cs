using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.WORD_FREQUENCY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "asdf asdf zxcv sjdh sjJH sg THHJJ zxcv thhjj";
            text = text.ToUpper();

            string[] textHERE = text.Split(' ', '.'); // массив с возможно повторяющимися словами

            Dictionary<string, int> word = new Dictionary<string, int>();

            for (int i = 0; i < textHERE.Length; i++)
            {
                string currentWord = textHERE[i];
                bool isIt = false;
                foreach (var item in word)
                {
                    if (currentWord == item.Key)
                    {
                        isIt = true;
                    }
                }

                if (isIt)
                {
                    word[currentWord]++;
                }
                else
                {
                    word.Add(currentWord, 1);
                }
            }

            foreach (KeyValuePair<string, int> keyValue in word)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
    }
}
