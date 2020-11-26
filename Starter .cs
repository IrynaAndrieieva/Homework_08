using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Starter
    {
        public void Run()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);

            for (int i = 0; i <= 100; i++)
            {

                if (i == value)
                {
                    Console.WriteLine($"Номер числа: {value}");
                    continue;
                }
            }

            Console.ReadKey();
        }
    }
}

