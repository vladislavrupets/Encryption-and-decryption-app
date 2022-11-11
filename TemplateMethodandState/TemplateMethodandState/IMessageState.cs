using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public interface IMessageState
    {     
        public void Encrypt(Message message);
        public void Decrypt(Message message);
        public void Print(Message message);
    }
}
