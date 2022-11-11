using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class ConsoleCrypt : Crypt
    {
        Message message;
        public ConsoleCrypt()
        {

        }
        public override string GetString()
        {
            /*Console.WriteLine("Введите строку которую нужно зашифровать");
            string content = Console.ReadLine();
            return content;*/
            return "яблоко"; //for test
        }
        public override string GetKey(Cipher cipher)
        {
            /*Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            return key;*/
            return "5"; //for test
        }
    }
    /*public class ConsoleCrypt : Crypt
    {
        Message message;
        public ConsoleCrypt()
        {

        }
        public override string GetString()
        {
            Console.WriteLine("Введите строку которую нужно зашифровать");
            string content = Console.ReadLine();
            return content;
        }

        public override void SaveString(Message encContent)
        {
            message = encContent;
        }
    }*/
}
