using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Queue01
{
    public class LinkedQueue<T>: IQueue<T>
    {
        public int Count { get; protected set; } = 0;
        protected LinkedQueueItem<T> Head { get; set; } = null;
        protected LinkedQueueItem<T> Tail { get; set; } = null;

        public IEnumerator<T> GetEnumerator() => new LinkedQueueEnumerator<T>(Tail);
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();

        public void PushTop(T value)
        {
            var item = new LinkedQueueItem<T>()
            {
                Value = value,
                PreviousItem = Head,
            };

            if (Tail is null)
            {
                Tail = item;
            } else
            {
                Head.NextItem = item;
            }

            Head = item;

            Count++;
        }
        public void PushEnd(T value)
        {
            var item = new LinkedQueueItem<T>()
            {
                Value = value,
            };

            if (Head is null)
            {
                Head = item;
            } else
            {
                item.NextItem = Tail;
                Tail.PreviousItem = item;
            }

            Tail = item;

            Count++;
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public T PopTop()
        {
            var result = PeekTop();
            Head = Head.PreviousItem;
            Head.NextItem = null;
            Count--;

            return result;
        }
        public T PopEnd()
        {
            var result = PeekEnd();
            Tail = Tail.NextItem;
            Count--;

            return result;
        }
        public T PeekTop() => Head.Value;
        public T PeekEnd() => Tail.Value;
        public bool IsEmpty { get => Count == 0; }
    }
}
