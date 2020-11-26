using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.Threading.Tasks;

namespace Homework_08
{
    class Starter

    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public void Run()
        {
            Action act = new Action();

            Random rnd = new Random();
            int value = rnd.Next(1,3);

            for (int i = 0; i <= 100; i++)
            {
              if (value == 1)
                {
                    act.Inform();
                }

              if (value == 2)
                {
                    act.Warning();
                }
                
              if (value == 3)
                {
                    act.Exception();
                }
            }


        }
    }
}

