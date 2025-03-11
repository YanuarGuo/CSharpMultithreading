using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMultithreading
{
    class ThreadsClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                Debug.WriteLine("Name of thread: " + thread.Name + " = " + i);
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }
        }

        public static void Thread2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Debug.WriteLine("Name of thread: " + thread.Name + " = " + i);
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
            }
        }
    }
}
