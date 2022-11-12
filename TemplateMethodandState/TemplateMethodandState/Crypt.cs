using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public abstract class Crypt
    {
        public void Encrypt(Message message, string savePath)
        {
            Message ecnContent = CreateMessage(message);
            ecnContent.Encrypt();
            PrintMessage(ecnContent);
            SaveString(ecnContent, savePath);
        }
        public void Decrypt(Message message, string savePath)
        {
            Message ecnContent = CreateMessage(message);
            ecnContent.Decrypt();
            PrintMessage(ecnContent);
            SaveString(ecnContent, savePath);
        }

        public virtual Message CreateMessage(Message message)
        {
            Message content = new Message(message.State, GetString(), GetKey(message.State));
            return content;
        }

        public abstract string GetString();

        public virtual void SaveString(Message content, string savePath)
        {
            WorkWithFiles.WriteToFile(content.ToString(), savePath);
        }

        public abstract string GetKey(IMessageState State);

        public virtual void PrintMessage(Message content)
        {
            Console.WriteLine(content.Content);
        }        
    }
}
