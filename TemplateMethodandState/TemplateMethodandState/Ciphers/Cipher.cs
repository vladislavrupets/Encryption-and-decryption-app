using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TemplateMethodandState
{
    /*public interface ICipher
    {
        public Message Encrypt(string message, string key);
        public Message Decrypt(string message, string key);
    }*/
     //111
   public class Cipher
   {
       public static string Alfabet { get => "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; } 
       public virtual string Encrypt(string message, string key) { return String.Empty; }
       public virtual string Decrypt(string message, string key) { return String.Empty; }
   }




}
