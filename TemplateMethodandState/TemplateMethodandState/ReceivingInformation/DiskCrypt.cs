using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class DiskCrypt : Crypt
    {
        private string key;
        private string readPath;
        
        public DiskCrypt(string readPath)
        {
            this.readPath = readPath;
        }

        public override string GetString()
        {
            string content = WorkWithFiles.ReadLineFromFile(readPath);
            string[] splt = content.Split(" ");
            key = splt[1];
            content = splt[0];
            return content;
        }
        public override string GetKey(IMessageState State)
        {
            if (key == "")
            {
                Random random = new Random();
                if (State is VigenereState)
                {
                    return new string(Enumerable.Repeat(Cipher.Alfabet, random.Next(1, 32))
                        .Select(s => s[random.Next(s.Length)]).ToArray());
                }
                else
                {
                    key = random.Next(1, 32).ToString();
                }
            }
            return key;
        }
    }
}
