using System;
using System.Threading;

namespace SeverCore
{
    class Program
    {
        static void MainThread(object state)
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Hello Thread");
        }

        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(MainThread); //백그라운드에서 돌아간다. 일종의 StartCoroutine이네
            //Thread t = new Thread(MainThread);
            //t.Name = "Test Thread";
            //t.IsBackground = true;
            //t.Start();
            //Console.WriteLine("Waiting For Thread");
            //t.Join();
            //Console.WriteLine("Hello World!");
        }
    }
}
