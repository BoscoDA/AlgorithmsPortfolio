using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment3DataStructures
{
    public static class DataLoader
    {
        public static Stack<Account> LoadXMLIntoStack(string fileName)
        {
            Stack<Account> accounts = new Stack<Account>();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode? root = doc.DocumentElement;
            XmlNodeList? accountList = root!.SelectNodes("/accounts/account");
            doc.AppendChild(root);
            foreach (XmlElement c in accountList!)
            {
                accounts.Push(new Account()
                {
                    Name = c.GetAttribute("Name"),
                    PhoneNumber = c.GetAttribute("PhoneNumber"),
                    EmailAdress = c.GetAttribute("EmailAddress"),
                    Password = c.GetAttribute("Password")
                });
            }
            return accounts;
        }

        public static Queue<Account> LoadXMLIntoQueue(string fileName)
        {
            Queue<Account> accounts = new Queue<Account>();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode? root = doc.DocumentElement;
            XmlNodeList? accountList = root!.SelectNodes("/accounts/account");
            doc.AppendChild(root);
            foreach (XmlElement c in accountList!)
            {
                accounts.Enqueue(new Account()
                {
                    Name = c.GetAttribute("Name"),
                    PhoneNumber = c.GetAttribute("PhoneNumber"),
                    EmailAdress = c.GetAttribute("EmailAddress"),
                    Password = c.GetAttribute("Password")
                });
            }
            return accounts;
        }

        public static Account[] LoadXMLIntoArray(string fileName)
        {
            Account[] accounts = new Account[52];
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode? root = doc.DocumentElement;
            XmlNodeList? accountList = root!.SelectNodes("/accounts/account");
            doc.AppendChild(root);
            int i = 0;
            foreach (XmlElement c in accountList!)
            {
                accounts[i] = (new Account()
                {
                    Name = c.GetAttribute("Name"),
                    PhoneNumber = c.GetAttribute("PhoneNumber"),
                    EmailAdress = c.GetAttribute("EmailAddress"),
                    Password = c.GetAttribute("Password")
                });
                i++;
            }
            return accounts;
        }

        public static Hashtable LoadXMLIntoHashTable(string fileName)
        {
            Hashtable accounts = new Hashtable();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode? root = doc.DocumentElement;
            XmlNodeList? accountList = root!.SelectNodes("/accounts/account");
            doc.AppendChild(root);
            foreach (XmlElement c in accountList!)
            {
                Account temp = new Account()
                {
                    Name = c.GetAttribute("Name"),
                    PhoneNumber = c.GetAttribute("PhoneNumber"),
                    EmailAdress = c.GetAttribute("EmailAddress"),
                    Password = c.GetAttribute("Password")
                };
                accounts.Add(temp.EmailAdress,temp);
            }
            return accounts;
        }
    }
}
