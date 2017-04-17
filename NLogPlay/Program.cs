using System;
using NLog;
using NLog.StructuredEvents;

namespace NLogPlay
{
    class Program
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            const string name = "marcos";
            _logger.Info("Hello world! {0}", name);
            _logger.Info("User {Name} is {Age} year's old", "Tom", 34);
            Console.WriteLine("Key");
            Console.ReadKey();
        }
    }
}
