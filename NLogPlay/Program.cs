using System;
using NLog;

namespace NLogPlay
{
    class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main()
        {
            Logger.Info("Hello world! {0}", "marcos");
            Logger.Info("User {Name} is {Age} year's old", "Tom", 34);

            Console.WriteLine("Key");
            Console.ReadKey();
        }
    }
}
