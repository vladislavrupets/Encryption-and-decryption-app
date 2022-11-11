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
        public void TestMethod1()//�iphers
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            Assert.AreEqual("������", caesarCipher.Encrypt("������", "3"));
            Assert.AreEqual("������", caesarCipher.Decrypt("������", "3"));

            VigenereCipher vigenereCipher = new VigenereCipher();
            Assert.AreEqual("������", vigenereCipher.Encrypt("������", "��������"));
            Assert.AreEqual("������", vigenereCipher.Decrypt("������", "��������"));

            TrithemiusCipher trithemiusCipher = new TrithemiusCipher();
            Assert.AreEqual("������", trithemiusCipher.Encrypt("������", "5"));
            Assert.AreEqual("������", trithemiusCipher.Decrypt("������", "5"));
        }
        [Test]
        public void TestMethod2()//Console Encrypt + DiskCrypt + InternetCrypt + Template Method
        {
            ConsoleCrypt consoleCrypt = new ConsoleCrypt();       
            consoleCrypt.Encrypt(new TrithemiusCipher());
            string answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("������ 5", answer);

            DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
            diskCrypt.Encrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("������ ��������", answer);

            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/");
            internetCrypt.Encrypt(new CaesarCipher());
            answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("������ 5", answer);
        }
        /* public void TestMethod3()//Encryption + Decryption
         {
             ConsoleCrypt consoleCrypt = new ConsoleCrypt();
             consoleCrypt.Encrypt(new TrithemiusCipher());
             string answer = WorkWithFiles.ReadFromFile("test.txt");
             Assert.AreEqual("������ 5", answer);

             DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
             diskCrypt.Encrypt(new VigenereCipher());
             answer = WorkWithFiles.ReadFromFile("test.txt");
             Assert.AreEqual("������ ��������", answer);

             InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/");
             internetCrypt.Encrypt(new TrithemiusCipher());
             answer = WorkWithFiles.ReadFromFile("test.txt");
             Assert.AreEqual("������ 5", answer);

         }*/

    }
}