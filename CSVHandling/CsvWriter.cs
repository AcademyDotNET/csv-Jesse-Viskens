using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVHandling
{
    class CsvWriter
    {
        public static void writeCsvNoStreamWriter()
        {
            string filepath = @"";
            StringBuilder output = new StringBuilder();
            output.AppendLine("");
            output.AppendLine("");

            File.WriteAllText(filepath, output.ToString());
            File.AppendAllText(filepath, output.ToString());
        }
        public static void writeCsvStreamWriter()
        {
            using (StreamWriter streamWriter = new StreamWriter(@""))
            {
                streamWriter.WriteLine("");
                streamWriter.WriteLine("");
            }
        }
    }
}
