using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.My_string
{
    internal class My_string
    {
        private char[] myChar;
        private string myString;

        public char[] MyChar
        {
            get
            {
                return myChar;
            }
            set
            {
                myChar = value;
            }
        }

        public string MyString
        {
            get
            {
                return myString;
            }
            set
            {
                myString = value;
            }
        }

        public char[] ToCharString (string s)
        {
            return this.MyChar = s.ToCharArray();
        }

        public string ToString(char[] ch)
        {
            string s1 = new string(ch);
            return s1;
        }

        public void Search (char ch)
        {
            bool flag = false;
            for (int i = 0; i < MyChar.Length; i++)
            {
                if (MyChar[i] == ch)
                {
                    Console.WriteLine("the character is in the string");
                    flag = true;
                    break;
                }
                if (flag)
                {
                    Console.WriteLine("the character is not in the string");
                }
            }
        }

        public void Compare(string s1, string s2)
        {
            if (s1 == s2)
            {
                Console.WriteLine("equally");
              }
            else
            {
                Console.WriteLine("not equally");
            }
        }
    }
}
