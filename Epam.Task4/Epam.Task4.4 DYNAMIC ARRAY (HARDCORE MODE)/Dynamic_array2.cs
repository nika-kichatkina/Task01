using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task4.DYNAMIC_ARRAY;

namespace Epam.Task4._4_DYNAMIC_ARRAY__HARDCORE_MODE_
{
    public class Dynamic_array2<T> : DynamicArray<T>, ICloneable
    {
        public Dynamic_array2() : base()
        {
        }

        public Dynamic_array2(int n) : base(n)
        {
        }

        public Dynamic_array2(IEnumerable<T> collection) : base(collection)
        {
        }

        public new int Capacity
        {
            get
            {
                return base.Capacity;
            }

            set
            {
                if (value >= this.Length)
                {
                    base.Capacity = value;
                }
                else
                {
                    T[] newArray = new T[value];
                    for (int i = 0; i < value; i++)
                    {
                        newArray[i] = this.MyArray[i];
                    }

                    base.Capacity = value;
                    this.MyArray = new T[value];

                    this.MyArray = newArray;
                    this.Length = value;
                }
            }
        }

        public override T this[int index]
        {
            get
            {
                if (Math.Abs(index) > this.Length)
                {
                    throw new ArgumentOutOfRangeException("Wrong index");
                }

                if (index < 0)
                {
                    return this.MyArray[this.Length + index];
                }

                return this.MyArray[index];
            }

            set
            {
                if (Math.Abs(index) > this.Length)
                {
                    throw new ArgumentOutOfRangeException("Wrong index");
                }

                if (index < 0)
                {
                    this.MyArray[this.Length + index] = value;
                }
                else
                {
                    this.MyArray[index] = value;
                }
            }
        }

        public object Clone()
        {
            Dynamic_array2<T> newMyClass = new Dynamic_array2<T>(this.MyArray);
            return newMyClass;
        }

        public T[] ToArray()
        {
            T[] newArray = new T[this.Length];

            for (int i = 0; i < this.Length; i++)
            {
                newArray[i] = this.MyArray[i];
            }

            return newArray;
        }
    }
}
