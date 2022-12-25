using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue01
{
    public class UnmutableQueue<T>: IQueue<T>
    {
        protected IQueue<T> Queue { get; private set; }

        public UnmutableQueue(IQueue<T> queue)
        {
            Queue = queue;
        }
        public IEnumerator<T> GetEnumerator() => Queue.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
        public void PushTop(T value) => throw new NotImplementedException();
        public void PushEnd(T value) => throw new NotImplementedException();
        public void Clear() => throw new NotImplementedException();
        public T PopTop() => throw new NotImplementedException();
        public T PopEnd() => throw new NotImplementedException();
        public T PeekTop() => Queue.PeekTop();
        public T PeekEnd() => Queue.PeekEnd();
        public int Count { get => Queue.Count; }
        public bool IsEmpty { get => Queue.IsEmpty; }
    }
}
