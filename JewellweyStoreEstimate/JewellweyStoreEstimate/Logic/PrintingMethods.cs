using System;
using JewelleryStoreEstimate.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JewelleryStoreEstimate.Logic
{
    //implemented various other printing techniques based on user preference
    class OnScreenPrinting : IPrintMessage
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class FilePrinting : IPrintMessage
    {
        public void PrintMessage(string message)
        {
            string fileName = FormFileName();
            WriteToFile(message, fileName);
        }

        private static void WriteToFile(string message, string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine(message);
                }
            }
            Console.WriteLine("Output stored in a text file in the path :" + fileName);
        }

        private static string FormFileName()
        {
            string file = string.Concat("text", "_", DateTime.Now.ToString("ddMMyyyyHHmmss"), ".txt");
            string fileName = @"D:\" + file;
            return fileName;
        }
    }

    class Printer : IPrintMessage
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine("Output will be sent to a printer");
        }
    }
}
