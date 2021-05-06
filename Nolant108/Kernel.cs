using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Nolant108.input;

namespace Nolant108
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Nolant108-OS Running!");
        }

        protected override void Run()
        {
            Console.Write("> ");
            Input.Maininput();

        }

        public static void reload()
        {
            Console.Write("> ");
            Input.Maininput();
        }
    }
}
