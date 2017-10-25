using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuimoKeytrigger
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Raw command-line: \n\t" + Environment.CommandLine);

            if (args.Length  == 1) {
                SendKeys.SendWait(args[0].Replace("nuimokeytrigger:", ""));
            }
            else
            {
                Console.WriteLine("wrong parameter count");
            }

        }
    }
}
