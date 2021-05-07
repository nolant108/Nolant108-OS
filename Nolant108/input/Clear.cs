using System;
using System.Collections.Generic;
using System.Text;

namespace Nolant108.input
{
    public class Clear
    {

        public static void clear()
        {
            Console.Clear();

            Kernel.reload();
        }

    }
}
