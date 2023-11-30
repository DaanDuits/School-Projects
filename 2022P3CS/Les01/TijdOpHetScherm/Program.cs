using System;
using System.Threading;

namespace TijdOpHetScherm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                showTime(getTime());
                Thread.Sleep(1000);
            }
        }
        static void showTime(string time)
        {
            Console.Clear();
            Console.WriteLine(time);
        }
        static string getTime()
        {
            string Time = DateTime.Now.ToString("HH:mm:ss");
            return Time;
        }
    }
}
