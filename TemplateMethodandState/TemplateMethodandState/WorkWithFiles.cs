using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class WorkWithFiles
    {
        public static void WriteToFile(string text, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(text);
            }
        }
        public static string ReadFromFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    return line;

                }
                return "err";
                
            }
        }
    }
}
