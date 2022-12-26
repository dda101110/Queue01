using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue01
{
    public class LinkedQueueItem<T>
    {
        public T Value { get; set; } = default(T);
        public LinkedQueueItem<T> NextItem { get; set; } = null;
        public LinkedQueueItem<T> PreviousItem { get; set; } = null;
        public bool IsHead() => NextItem == null;
        public bool IsTail() => PreviousItem == null;
    }
}
