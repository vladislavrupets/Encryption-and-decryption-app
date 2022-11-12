using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public class ConsoleCrypt : Crypt
    {       
        public ConsoleCrypt()
        {

        }
        public override string GetString()
        {
            /*Console.WriteLine("Введите строку");
            string content = Console.ReadLine();
            return content;*/
            return "жхичкэ";//for test
            //return "джтцуш"; //for test
        }
        public override string GetKey(IMessageState State)
        {
            /*Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            return key;*/
            return "7"; //for test
        }
    }
}
