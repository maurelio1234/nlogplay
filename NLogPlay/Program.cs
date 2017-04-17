using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NLogPlay
{
    class Program
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            const string name = "marcos";
            _logger.Info("Hello world! {0}", name);
            Console.ReadKey();
        }
    }
}
