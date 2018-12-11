using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task4.DYNAMIC_ARRAY;

namespace Epam.Task4._4_DYNAMIC_ARRAY__HARDCORE_MODE_
{
    public class CycledDynamicArray<T> : DynamicArray<T>
    {
        public override IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= this.Length; i++)

            {
                if (i == this.Length)
                {
                    i = -1;
                    continue;
                }

                yield return this.MyArray[i];
            }
        }
    }
}
