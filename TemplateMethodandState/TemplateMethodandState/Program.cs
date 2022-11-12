using System;

namespace TemplateMethodandState 
{
    public class Program
    {
        static void Main(string[] args)
        {

            Message message2 = new Message(new TrithemiusState());
            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/",
                @"D:\For_Git\TemplateMethodandState\TestProject1\TextMatch.txt");
            internetCrypt.Encrypt(message2, @"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");


        }
    }
}