using System;
using System.Threading;

namespace MyFirstMultithreadProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // thread = an execution path of a program
            //          We can use multiple threads to perform,
            //          different tasks of our program at the same time.
            //          Current thread running is "main" thread
            //          using System.Threading;

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));
            Thread thread3 = new Thread(() => CountUp2("Timer #3"));
            Thread thread4 = new Thread(() => CountDown2("Timer #4"));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            Console.WriteLine(mainThread.Name + " is complete!");

            Console.ReadKey();
        }
        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
        public static void CountUp2(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #3 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #3 is complete!");
        }
        public static void CountDown2(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #4 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #4 is complete!");
        }
    }
}