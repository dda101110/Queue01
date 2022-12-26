using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue01
{
    public class LinkedQueueEnumerator<T>: IEnumerator<T>
    {
        protected LinkedQueueItem<T> Tail { get; set; }
        protected LinkedQueueItem<T> Item { get; set; }
        protected bool HasValue { get; set; } = true;

        public LinkedQueueEnumerator(LinkedQueueItem<T> item)
        {
            Tail = item;
            Reset();
        }

        public void Reset()
        {
            Item = Tail;
        }

        public bool MoveNext()
        {
            var result = HasValue || !Item.IsHead();

            if (Item.IsHead() || HasValue)
            {
                HasValue = false;
            } else
            {
                Item = Item.NextItem;
            }

            return result;
        }

        object IEnumerator.Current { get => Item.Value; }

        T IEnumerator<T>.Current { get => Item.Value; }

        public void Dispose()
        {
            Item = null;
        }
    }
}
