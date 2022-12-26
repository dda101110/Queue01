using Queue01;

Console.WriteLine("Example 01 / ArrayQueue \r\n");

IQueue<string> queue = new ArrayQueue<string>();
Action<string> displayQueue = (string actionQueue) => Console.WriteLine($"{actionQueue}, Count:{queue.Count}, Queue:{String.Join(",", queue.ToArray())}");

queue.PushEnd("10");
displayQueue("PushEnd(10)");

queue.PushEnd("11");
displayQueue("PushEnd(11)");

queue.PushEnd("12");
displayQueue("PushEnd(12)");

queue.PushTop("20");
displayQueue("PushTop(20)");

var element = queue.PeekTop();
displayQueue($"PeekTop()={element}");

element = queue.PeekEnd();
displayQueue($"PeekEnd()={element}");

element = queue.PopTop();
displayQueue($"PopTop()={element}");

element = queue.PopEnd();
displayQueue($"PopEnd()={element}");

Console.WriteLine("\r\nExample 02 / UnmutableQueue\r\n");

var unmutableQueue = new UnmutableQueue<string>(queue);

element = unmutableQueue.PeekTop();
displayQueue($"PeekTop()={element}");

element = unmutableQueue.PeekEnd();
displayQueue($"PeekEnd()={element}");

try
{
    element = unmutableQueue.PopTop();
    displayQueue($"PopTop()={element}");
} catch
{
    displayQueue($"exception PopTop()");
}

try
{
    element = unmutableQueue.PopEnd();
    displayQueue($"PopEnd()={element}");
} catch
{
    displayQueue($"exception PopEnd()");
}

Console.WriteLine("\r\nExample 03 / LinkedQueue\r\n");
queue = new LinkedQueue<string>();

queue.PushEnd("20");
displayQueue("PushEnd(20)");

queue.PushEnd("10");
displayQueue("PushEnd(10)");

queue.PushTop("30");
displayQueue("PushTop(30)");

element = queue.PopTop();
displayQueue($"PopTop()={element}");

element = queue.PopEnd();
displayQueue($"PopEnd()={element}");


