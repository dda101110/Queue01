using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue01
{
    public interface IQueue<T>: IEnumerable<T>
    {
        void PushTop(T value);
        void PushEnd(T value);
        void Clear();
        T PopTop();
        T PopEnd();
        T PeekTop();
        T PeekEnd();
        int Count { get; }
        bool IsEmpty { get; }
    }
}
