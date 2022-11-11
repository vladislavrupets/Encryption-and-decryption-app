using System;

namespace TemplateMethodandState 
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*ConsoleCrypt consoleCrypt = new ConsoleCrypt();
            consoleCrypt.Encrypt(new TrithemiusCipher());*/
            /*DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
            diskCrypt.Encrypt(new VigenereCipher());*/
            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/");
            internetCrypt.Encrypt(new CaesarCipher());
        }
    }
}