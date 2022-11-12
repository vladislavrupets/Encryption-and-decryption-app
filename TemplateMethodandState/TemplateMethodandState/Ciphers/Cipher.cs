using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TemplateMethodandState
{
   public class Cipher
   {
       public static string Alfabet { get => "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; } 
       public virtual Message Encrypt(Message message) { return new Message(""); }
       public virtual Message Decrypt(Message message) { return new Message(""); }
   }
}
