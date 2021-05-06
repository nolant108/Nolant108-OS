using Nolant108.cmd;
using Nolant108.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nolant108.input
{
    public static class Input
    {

        static string cmdinput;

        public static void Maininput()
        {
            cmdinput = Console.ReadLine();

                if (cmdinput == "hello"){Hello.hello();}
                if (cmdinput == "reboot"){Reboot.reboot();}
                if (cmdinput == "shutdown"){Shutdown.shutdown();}
                if (cmdinput == "about"){About.about();}
                if (cmdinput == "calc"){ calculatorCommand.calccmd();}
                if (cmdinput == "etc") {Etc.etc(); }
                if (cmdinput == "time") { time.Main(); }

                //GUI
                if (cmdinput == "gui") { GuiMain.guimain();}

        }

    }
}
