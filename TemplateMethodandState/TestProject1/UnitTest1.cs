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

        /*[Test]
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
            string answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("������ 5", answer);

            DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
            diskCrypt.Encrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("������ ��������", answer);

            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/");
            internetCrypt.Encrypt(new CaesarCipher());
            answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("������ 5", answer);
        }
        [Test]
        public void TestMethod3()//Encryption + Decryption
        {
            ConsoleCrypt consoleCrypt = new ConsoleCrypt();
            consoleCrypt.Decrypt(new TrithemiusCipher());
            string answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("������ 5", answer);

            DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
            diskCrypt.Encrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("������ ��������", answer);

            diskCrypt = new DiskCrypt("test.txt");
            diskCrypt.Decrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("������ ��������", answer);
        }*/
        [Test]
        public void TestMethod4()//�ipher definition + State
        {
            Message message = new Message(new UnknownState(@"D:\For_Git\TemplateMethodandState\TestProject1\TextMatch.txt"));
            ConsoleCrypt consoleCrypt = new ConsoleCrypt();
            consoleCrypt.Decrypt(message, @"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            string answer = WorkWithFiles.ReadLineFromFile(@"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            Assert.AreEqual("������ 7", answer);

            Message message1 = new Message(new UnknownState(@"D:\For_Git\TemplateMethodandState\TestProject1\TextMatch.txt"));
            DiskCrypt diskCrypt = new DiskCrypt(@"D:\For_Git\TemplateMethodandState\TestProject1\TextR.txt");
            diskCrypt.Decrypt(message1, @"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            answer = WorkWithFiles.ReadLineFromFile(@"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            Assert.AreEqual("���� ����", answer);

            Message message2 = new Message(new TrithemiusState());
            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/", 
                @"D:\For_Git\TemplateMethodandState\TestProject1\TextMatch.txt");
            internetCrypt.Encrypt(message2, @"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            answer = WorkWithFiles.ReadLineFromFile(@"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            Assert.AreEqual("������ 10", answer);
        }

    }
}