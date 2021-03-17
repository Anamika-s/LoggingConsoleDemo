using log4net.Config;
using LoggingDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingConsoleDemo
{
    class Program
    {
       private static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Program));  //Declaring Log4Net  

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            logger.Error("Its an error");
            logger.Warn("Warning");
            Log.Error("Login-page started...");

        }
    }
}
