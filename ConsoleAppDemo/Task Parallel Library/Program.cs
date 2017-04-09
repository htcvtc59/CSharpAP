using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Parallel_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskTwo();
            Console.ReadKey();
        }
        static void Taskone() {
            var t1 = new Task(() => DoWork(1, 1000));
            t1.Start();
            var t2 = new Task(() => DoWork(2, 3000));
            t2.Start();
            var t3 = new Task(() => DoWork(3, 1500));
            t3.Start();
            Console.WriteLine("Press any key to exit...||");
        }
        static void TaskTwo() {
            Task t1 = Task.Factory.StartNew(()=>DoWork(1,2000)).ContinueWith((prev)=> DoOtherWork(1,2000));
            Task t2 = Task.Factory.StartNew(()=>DoWork(2,2500));
            Task t3 = Task.Factory.StartNew(()=>DoWork(3,1500));
        }
        static void DoWork(int id,int sleep) {
            Console.WriteLine("Task {0} is beginning...",id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...",id);
        }
        static void DoOtherWork(int id, int sleep)
        {
            Console.WriteLine("Other Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Other Task {0} is completed...", id);
        }
    }
}
