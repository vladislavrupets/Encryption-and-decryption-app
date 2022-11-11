/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class MessageEncrypted : IMessageState
    {
        public void Decrypt(Message message)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            caesarCipher.Decrypt(message);
        }

        public void Encrypt(Message message)
        {
            throw new NotImplementedException();
        }

        public void Print(Message message)
        {

        }
    }
}
*/