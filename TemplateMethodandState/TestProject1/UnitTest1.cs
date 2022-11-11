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
        public void TestMethod1()//—iphers
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            Assert.AreEqual("вдоснс", caesarCipher.Encrypt("€блоко", "3"));
            Assert.AreEqual("€блоко", caesarCipher.Decrypt("вдоснс", "3"));

            VigenereCipher vigenereCipher = new VigenereCipher();
            Assert.AreEqual("€рръжа", vigenereCipher.Encrypt("€блоко", "апельсин"));
            Assert.AreEqual("€блоко", vigenereCipher.Decrypt("€рръжа", "апельсин"));

            TrithemiusCipher trithemiusCipher = new TrithemiusCipher();
            Assert.AreEqual("джтцуш", trithemiusCipher.Encrypt("€блоко", "5"));
            Assert.AreEqual("€блоко", trithemiusCipher.Decrypt("джтцуш", "5"));
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
            Assert.AreEqual("€рръжа апельсин", answer);

            InternetCrypt internetCrypt = new InternetCrypt("https://gastronom.com.ua/fruit/");
            internetCrypt.Encrypt(new CaesarCipher());
            answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("ететец 5", answer);
        }
        [Test]
        public void TestMethod3()//Encryption + Decryption
        {
            ConsoleCrypt consoleCrypt = new ConsoleCrypt();
            consoleCrypt.Decrypt(new TrithemiusCipher());
            string answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("€блоко 5", answer);

            DiskCrypt diskCrypt = new DiskCrypt("testR.txt");
            diskCrypt.Encrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("€рръжа апельсин", answer);

            diskCrypt = new DiskCrypt("test.txt");
            diskCrypt.Decrypt(new VigenereCipher());
            answer = WorkWithFiles.ReadFromFile("test.txt");
            Assert.AreEqual("€блоко апельсин", answer);

        }

    }
}