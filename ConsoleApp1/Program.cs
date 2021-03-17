using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Program));  //Declaring Log4Net  

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            
            logger.Warn("Logging is started");
            int x, y;
            try
            {
                Console.WriteLine("Enter x");
                x = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter y");
                y = Convert.ToByte(Console.ReadLine());
                int z = 0;
                z = x % y;
            }
            catch(Exception ex)
            {
                logger.Fatal(ex.Message);
            }
           

        }
    }
}
