using System;
using System.Diagnostics;
using System.Threading;

namespace TaskConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            Console.WriteLine("開始早餐製作...");
            平底鍋預熱();
            烤吐司();
            煎火腿蛋();
            抹果醬();
            倒咖啡();
            吐司夾火腿蛋();
            擺盤完成開始吃早餐();
            watch.Stop();

            Console.WriteLine($"同步烹煮早餐共花費:{watch.Elapsed.Seconds} 秒");
            Console.ReadKey();
        }

        static void 平底鍋預熱()
        {
            Console.WriteLine($"預熱平底鍋 5 秒鐘 [Thread ID:{Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(5000);
            Console.WriteLine($"預熱完成");
        }

        static void 烤吐司()
        {
            Console.WriteLine($"烤吐司 10 秒鐘 [Thread ID:{Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(10000);
            Console.WriteLine($"烤吐司完成");
        }

        static void 煎火腿蛋()
        {
            Console.WriteLine($"煎火腿蛋 20 秒鐘 [Thread ID:{Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(20000);
            Console.WriteLine($"煎火腿蛋完成");
        }

        static void 抹果醬()
        {
            Console.WriteLine($"抹果醬需要 2 秒鐘 [Thread ID:{Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(2000);
            Console.WriteLine($"抹果醬完成");
        }

        static void 倒咖啡()
        {
            Console.WriteLine($"倒咖啡需要 5 秒鐘 [Thread ID:{Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(5000);
            Console.WriteLine($"倒咖啡完成");
        }
        static void 吐司夾火腿蛋()
        {
            Console.WriteLine($"吐司夾火腿蛋需要 3 秒鐘 [Thread ID:{Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(3000);
            Console.WriteLine($"吐司火腿蛋完成");
        }

        static void 擺盤完成開始吃早餐()
        {
            Console.WriteLine($"擺盤上桌需要 2 秒鐘 [Thread ID:{Thread.CurrentThread.ManagedThreadId}]");
            Thread.Sleep(2000);
            Console.WriteLine($"早餐可以吃了");
        }
    }
}