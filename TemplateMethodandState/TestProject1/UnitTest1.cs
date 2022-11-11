using NUnit.Framework;
using TemplateMethodandState;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()//Сiphers
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            Assert.AreEqual("вдоснс", caesarCipher.Encrypt("яблоко", "3"));
            Assert.AreEqual("яблоко", caesarCipher.Decrypt("вдоснс", "3"));

            VigenereCipher vigenereCipher = new VigenereCipher();
            Assert.AreEqual("ярръжа", vigenereCipher.Encrypt("яблоко", "апельсин"));
            Assert.AreEqual("яблоко", vigenereCipher.Decrypt("ярръжа", "апельсин"));

            TrithemiusCipher trithemiusCipher = new TrithemiusCipher();
            Assert.AreEqual("джтцуш", trithemiusCipher.Encrypt("яблоко", "5"));
            Assert.AreEqual("яблоко", trithemiusCipher.Decrypt("джтцуш", "5"));
        }
        [Test]
        public void TestMethod2()//Console Encrypt + DiskCrypt + InternetCrypt + Template Method
        {
            ConsoleCrypt consoleCrypt = new ConsoleCrypt();       
            consoleCrypt.Encrypt(new TrithemiusCipher());
            string answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("джтцуш 5", answer);

            DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
            diskCrypt.Encrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("ярръжа апельсин", answer);

            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/");
            internetCrypt.Encrypt(new CaesarCipher());
            answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("ететец 5", answer);
        }
        /* public void TestMethod3()//Encryption + Decryption
         {
             ConsoleCrypt consoleCrypt = new ConsoleCrypt();
             consoleCrypt.Encrypt(new TrithemiusCipher());
             string answer = WorkWithFiles.ReadFromFile("test.txt");
             Assert.AreEqual("джтцуш 5", answer);

             DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
             diskCrypt.Encrypt(new VigenereCipher());
             answer = WorkWithFiles.ReadFromFile("test.txt");
             Assert.AreEqual("ярръжа апельсин", answer);

             InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/");
             internetCrypt.Encrypt(new TrithemiusCipher());
             answer = WorkWithFiles.ReadFromFile("test.txt");
             Assert.AreEqual("еужхиы 5", answer);

         }*/

    }
}