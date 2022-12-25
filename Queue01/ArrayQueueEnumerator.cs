using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue01
{
    public class ArrayQueueEnumerator<T> : IEnumerator<T>
    {
        protected T[] Items { get; set; }
        protected int Index { get; set; }

        public ArrayQueueEnumerator(T[] items)
        {
            Items = items;
            Reset();
        }
        public void Reset()
        {
            Index = -1;
        }

        public bool MoveNext()
        {
            var result = Items.Length > ++Index;

            return result;
        }

        object IEnumerator.Current { get => Items[Index]; }

        T IEnumerator<T>.Current { get => Items[Index]; }

        public void Dispose()
        {
            Items = new T[0];
        }
    }
}
