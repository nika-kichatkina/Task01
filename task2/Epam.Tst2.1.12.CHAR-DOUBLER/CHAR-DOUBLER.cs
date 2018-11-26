using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Tst2.CHAR_DOUBLER
{
    class CHAR_DOUBLER
    {
        static void Main(string[] args)
        {
            string s1;
            Console.WriteLine("Введите первую строку: ");
            s1 = Console.ReadLine();
               

            string s2;
            Console.WriteLine("Введите вторую строку: ");
            s2 = Console.ReadLine();
                       
            string finalS = "1";
            
            for (int i = 0; i < s1.Length; i++)         //сравниваем 2 строки, если буквы совпали, то записываем их в finalS
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if ((s1[i] == s2[j]) && (s1[i] != '?') && (s1[i] != '!') && (s1[i] != ',') && (s1[i] != '.'))
                    {
                        int flag = 0;
                        for (int k = 0; k < finalS.Length; k++)
                        {

                            if (s1[i] == finalS[k])
                            {
                                flag++;
                            }
                            
                        }
                        if (flag == 0) finalS += s1[i];

                    }
                       
                }

             }

            
            for (int i = 0; i < s1.Length; i++)                
            {
                Console.Write(s1[i]);
                for (int j = 1; j < finalS.Length; j++)
                {
                    
                    if (s1[i] == finalS[j])
                    {
                        Console.Write(s1[i]);
                        break;
                    }
                }
            }


                    







            /*for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s2[j] != ' ') || (s2[j] != '!') 
            }
            */

        }
    }
}
