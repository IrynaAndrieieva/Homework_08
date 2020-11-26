using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.Threading.Tasks;

namespace Homework_08
{
    class Action
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public void Inform()
        {
            logger.Info("\nStart method");
            Console.WriteLine("\nlogger.Info: Start method");
        }

        public void Warning()
        {
            logger.Warn("\nSkipped logic in method");
            Console.WriteLine("\nlogger.Warn: Skipped logic in method");
        }

        public void Exception()
        {
            try
            {
                throw new Exception("\nI broke a toilet");
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace + "\nI broke a toilet");
            }
        }

        public void Error()
        {
            logger.Error("Action failed by reason");
            Console.WriteLine("logger.Error: Saction failed by reason");
        }

        

    }
}
