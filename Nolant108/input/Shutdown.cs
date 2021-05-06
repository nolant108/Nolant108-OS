using System;
using System.Collections.Generic;
using System.Text;

namespace Nolant108.input
{
   public class Shutdown
    {

        public static void shutdown()
        {
            Cosmos.System.Power.Shutdown();
        }

    }
}
