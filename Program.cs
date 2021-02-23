using System;
using System.IO;

namespace randomFilePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string usage = "randomFilePicker path/to/file \"file extension\"";
            if (args.Length == 2)
            {
                
                string[] filepaths = Directory.GetFiles(@args[0], args[1], SearchOption.AllDirectories);
                int numberOfFiles = filepaths.Length;
                Random rand = new Random();
                int fileTargetNumber = rand.Next(0, numberOfFiles);
                string fileTarget = filepaths[fileTargetNumber];
                Console.WriteLine($"Opening \"{fileTarget}\"");
                using (System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
                    {
                        pProcess.StartInfo.FileName = $"{fileTarget}";
                        pProcess.StartInfo.UseShellExecute = true;
                        pProcess.StartInfo.RedirectStandardOutput = false;
                        pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        pProcess.Start();
                        pProcess.WaitForExit();
                        Environment.Exit(0);
                    }
            }
            else
            {
                Console.WriteLine("Please Enter a File Path");
                Console.WriteLine($"Usage: {usage}");
                Environment.Exit(0);
            }
        }
    }
}
