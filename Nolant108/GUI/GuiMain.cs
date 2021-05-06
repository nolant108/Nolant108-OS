using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace Nolant108.GUI
{
    public class GuiMain
    {

       static Canvas canvas;

        public static void guimain()
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas();

            Console.WriteLine("OK Switching...");

            canvas.Clear(Color.Gray);

            Kernel.reload();
        }
    }
}
