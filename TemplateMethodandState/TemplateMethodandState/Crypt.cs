using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public abstract class Crypt
    {
        public void Encrypt(Cipher cipher)
        {

            string encContent = GetString();
            string key = GetKey(cipher);
            encContent = ApplyEncryption(encContent, key, cipher);
            PrintMessage(encContent);
            SaveString(encContent + " " + key, "test.txt");
        }
        public void Decrypt(Cipher cipher)
        {
            string content = GetString();
            string key = GetKey(cipher);
            content = ApplyDecryption(content, key, cipher);
            PrintMessage(content);
            SaveString(content + " " + key, "Rtest.txt");
        }



        public abstract string GetString();
        public virtual void SaveString(string content, string path)
        {
            WorkWithFiles.WriteToFile(content, path);
        }
        public abstract string GetKey(Cipher cipher);

        public virtual void PrintMessage(string content)
        {
            Console.WriteLine(content);
        }
        public virtual string ApplyEncryption(string content, string key, Cipher cipher)
        {
            return cipher.Encrypt(content, key);
        }
    }

        public virtual string ApplyDecryption(string content, string key, Cipher cipher)
        {
            return cipher.Decrypt(content, key);
        }
        /*    public abstract class Crypt
            {
                public string Encrypt(Cipher cipher)
                {
                    Message encContent;
                    encContent = ApplyEncryption(CreateMessage(), cipher);
                    PrintMessage(encContent);
                    SaveString(encContent);
                    return encContent.Content;
                }
                public void Decrypt()
                {

                }

                public virtual Message CreateMessage()
                {
                    Message content = new Message(new MessageDecrypted(), GetString(), GetKey());
                    return content;
                }
                public abstract Message GetEncryptedMessage(Message message)
                {
                    Message encContent = new Message(new MessageEncrypted(), message.Content, message.Key);
                }
                //public abstract void SetUpAlgorithm();
                public abstract string GetString();
                public abstract Message SaveString(Message encContent);
                public virtual int GetKey()
                {
                    Console.WriteLine("Введите ключ");
                    int key = Convert.ToInt32(Console.ReadLine());
                    return key;
                }
                public virtual void PrintMessage(Message content)
                {
                    Console.WriteLine(content.Content);
                }
                public virtual Message ApplyEncryption(Message content, Cipher cipher)
                {
                    return cipher.Encrypt(content);
                }

                public virtual Message ApplyDecryption(Message content, Cipher cipher)
                {
                    return cipher.Decrypt(content);
                }
            }*/
    }
}
