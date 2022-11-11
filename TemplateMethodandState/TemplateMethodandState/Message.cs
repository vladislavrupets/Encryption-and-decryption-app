using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class Message
    {
        public string Content { get; set; }
        public int Key { get; set; }
        public IMessageState State { get; set; }

        public Message(IMessageState messageState, string content, int key)
        {
            State = messageState;
            Content = content;
            Key = key;
        }

        public Message(string content)
        {
            this.Content = content;
        }

        public Message(string content, int key)
        {
            Content = content;
            Key = key;
        }

        public Message() { }

        public void Encrypt()
        {
            State.Encrypt(this);
        }
        public void Decrypt()
        {
            State.Decrypt(this);
        }
        public void Print()
        {
            State.Print(this);
        }
    }
}
