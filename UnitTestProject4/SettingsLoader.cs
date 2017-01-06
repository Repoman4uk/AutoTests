using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SeleniumTests
{
    public static class SettingsLoader
    {
        public static string file = "Settings.xml";
        private static string baseURL;
        private static string login;
        private static string password;
        private static XmlDocument document;

        public static string BaseURL
        {
            get
            {
                if (baseURL == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("baseUrl");
                    baseURL = node.InnerText;
                }
                return baseURL;
            }

        }

        public static string Login
        {
            get
            {
                if (login == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("login");
                    login = node.InnerText;
                }
                return login;
            }

        }

        public static string Password
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("password");
                    password = node.InnerText;
                }
                return password;
            }
        }

        static SettingsLoader()
        {
            if (!System.IO.File.Exists(file))
            {
                document = new XmlDocument();
                document.Load(file);
            }
        }

    }
}
