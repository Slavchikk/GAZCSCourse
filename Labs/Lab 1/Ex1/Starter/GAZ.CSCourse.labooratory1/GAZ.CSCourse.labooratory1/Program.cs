using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GAZ.CSCourse.labooratory1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buffer to hold a line as it is read in
            // Buffer to hold a line as it is read in
            string line;
            string allText = "";
            // Loop until no more input (Ctrl-Z in a console, or end-of-file)
            StreamReader f = new StreamReader("DataFile.txt");
            while (!f.EndOfStream)
            {
                line = f.ReadLine();
                line = line.Replace(",", " y:");
                line = "x:" + line;
                allText += line;
            }
            f.Close();
            StreamWriter d = new StreamWriter("DataFile.txt");
            d.Write(allText);
           
            d.Close();
        }
    }
}
/*23.8976,12.3218
25.7639,11.9463
24.8293,12.2134
*/