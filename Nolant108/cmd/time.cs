using System;
using System.Collections.Generic;
using System.Text;

namespace Nolant108.cmd
{
    public class time
    {

        public static void Main()
        {
            DateTime dat = DateTime.Now;

            //print current date and time and moves cursor to next line
            Console.WriteLine("Current Date and time is : " + dat);

            //prints text but keeps cursor in same line
            Console.Write("Press ENTER to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Current Date and time is : " + dat);
            }
        }

    }
}
