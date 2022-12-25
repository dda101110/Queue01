using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue01
{
    public class ArrayQueue<T> : IQueue<T>
    {
        protected T[] Items { get; set; } = new T[0];

        public IEnumerator<T> GetEnumerator() => new ArrayQueueEnumerator<T>(Items);
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();

        public void PushTop(T value)
        {
            var newArray = new T[Items.Length + 1];
            newArray[0] = value;
            Items.CopyTo(newArray, 1);
            Items = newArray;
        }
        public void PushEnd(T value)
        {
            var newArray = new T[Items.Length + 1];
            newArray[Items.Length] = value;
            Items.CopyTo(newArray, 0);
            Items = newArray;
        }
        public void Clear()
        {
            Items = new T[0];
        }
        public T PopTop()
        {
            var result = PeekTop();
            //Array.Resize(ref Items, Items.Length-1);

            return result;
        }
        public T PopEnd()
        {
            var result = PeekEnd();
            //Array.Resize(ref Items, Items.Length-1);

            return result;
        }
        public T PeekTop()
        {
            var result = Items[0];

            return result;
        }
        public T PeekEnd()
        {
            var result = Items[Items.Length-1];

            return result;
        }
        public int Count { get => Items.Length; }
        public bool IsEmpty { get => Count == 0; }
    }
}
