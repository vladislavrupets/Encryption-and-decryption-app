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
            string answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("джтцуш 5", answer);

            DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
            diskCrypt.Encrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("ярръжа апельсин", answer);

            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/");
            internetCrypt.Encrypt(new CaesarCipher());
            answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("ететец 5", answer);
        }
        [Test]
        public void TestMethod3()//Encryption + Decryption
        {
            ConsoleCrypt consoleCrypt = new ConsoleCrypt();
            consoleCrypt.Decrypt(new TrithemiusCipher());
            string answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("яблоко 5", answer);

            DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
            diskCrypt.Encrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("ярръжа апельсин", answer);

            diskCrypt = new DiskCrypt("test.txt");
            diskCrypt.Decrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadLineFromFile("test.txt");
            Assert.AreEqual("яблоко апельсин", answer);
        }*/
        [Test]
        public void TestMethod4()//Сipher definition + State
        {
            Message message = new Message(new UnknownState(@"D:\For_Git\TemplateMethodandState\TestProject1\TextMatch.txt"));
            ConsoleCrypt consoleCrypt = new ConsoleCrypt();
            consoleCrypt.Decrypt(message, @"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            string answer = WorkWithFiles.ReadLineFromFile(@"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            Assert.AreEqual("ананас 7", answer);

            Message message1 = new Message(new UnknownState(@"D:\For_Git\TemplateMethodandState\TestProject1\TextMatch.txt"));
            DiskCrypt diskCrypt = new DiskCrypt(@"D:\For_Git\TemplateMethodandState\TestProject1\TextR.txt");
            diskCrypt.Decrypt(message1, @"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            answer = WorkWithFiles.ReadLineFromFile(@"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            Assert.AreEqual("лайм киви", answer);

            Message message2 = new Message(new TrithemiusState());
            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/", 
                @"D:\For_Git\TemplateMethodandState\TestProject1\TextMatch.txt");
            internetCrypt.Encrypt(message2, @"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            answer = WorkWithFiles.ReadLineFromFile(@"D:\For_Git\TemplateMethodandState\TestProject1\TextW.txt");
            Assert.AreEqual("йшлъна 10", answer);
        }

    }
}