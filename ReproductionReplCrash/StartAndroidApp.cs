using System;
using System.Diagnostics;
using System.Threading;

namespace ReproductionReplCrash
{
    public class StartAndroidApp
    {
        public static void ExecuteEmulatorShellCommand()
        {
            ProcessStartInfo emulatorShell = new ProcessStartInfo();


            // executes command file which cleans the emulator environment and starts it afterwards
            emulatorShell.FileName = GlobalParameters.emulatorStartFile;
            Process p = Process.Start(emulatorShell);
            // Waits until the emulator is started and cancels the shell execution
            p.WaitForExit();

            // Waits for 8 seconds to give the emulator time to finish initializing
            Thread.Sleep(8000);
        }
    }
}