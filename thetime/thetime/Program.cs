using System;
using System.Timers;

namespace thetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer(2000);
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            Console.ReadLine();
            timer.Stop();
            timer.Dispose();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer fired at {0}", DateTime.Now.ToString());
        }
    }
}
