using System.Threading;

namespace Program3.Console
{
    static class StaticMethodsForConsole
    {
        static public void PrintCounterOnConsole(int maxvalue, int interval)
        {
            for (int i = 1; i <= maxvalue; i++)
            {
                var threadName = Thread.CurrentThread.Name;
                System.Console.WriteLine($"{threadName}: {i}");
                Thread.Sleep(interval);
            }
        }
    }
}