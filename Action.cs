﻿using System;
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
            logger.Info("Start method");
            Console.WriteLine("Start method");
        }

        public void Warning()
        {
            logger.Warn("Skipped logic in method");
            Console.WriteLine("Skipped logic in method");
        }

        public void Exception()
        {
            try
            {
                throw new Exception("I broke a toilet");
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace + "\n");
            }
        }

    }
}
