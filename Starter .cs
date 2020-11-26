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
            int value = rnd.Next(0, 100);

            for (int i = 0; i < 100; i++)

            {

                if ((i + value) % 2 == 0)
                {
                    act.Inform();
                }
                else
                {
                    if ((i + value) % 3 == 0)
                    {
                        act.Warning();
                    }
                    else

                    if ((i + value) % 5 == 0)
                    {
                        act.Exception();
                    }
                    else
                    {
                        act.Error();
                    }
                }
            }

           


        }
    }
}

