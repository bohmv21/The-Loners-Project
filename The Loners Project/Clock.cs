using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Escape_Room
{
    class Clock
    {
        public static void Time()
        {
            int Time = 0;
            do
            {
                Time++;
                Thread.Sleep(1000);
            } while (Time <= 3600);

            Environment.Exit(0);
        }

    }
}
