using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.My_string
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string S = "jf jdfh jsdFA djhfj";
            char[] arrayChar = { 's', 'w', 'e', 'w', 'w', 'y', 'n', 's', 'w', 'q', 'j' };
            string S1 = "jf jdfh jsdFA djhfj";
            string S2 = "fjkkgjfdgfjk fkd gdfjk";

            My_string MyNewString = new My_string();



            MyNewString.ToCharString(S);

            MyNewString.Search('A');

            MyNewString.ToString(arrayChar);

            MyNewString.Compare(S, S1);

            MyNewString.Compare(S2, S1);



        }
    }
}
