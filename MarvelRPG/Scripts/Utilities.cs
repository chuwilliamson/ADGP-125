using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MarvelRPG
{
    public static class Utilities
    {
        public static void SerializeXML<T>(string s, T t, string path)
        {
            if (Directory.Exists(path))
            {
                using (FileStream fs = File.Create(path + s + ".xml"))
                {
                    try {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));


                        serializer.Serialize(fs, t);
                        fs.Close();
                    }
                    catch(XmlException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Exception object Line, pos: (" + e.LineNumber + "," + e.LinePosition + ")");
                        throw e;
                       
                    }
                }
            }
            else
            {
                string appName = System.Windows.Forms.Application.ProductName;
                Directory.CreateDirectory(path + appName);
            }

        }

        /// <summary>
        /// deserialize from a path
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s"></param>
        /// <returns></returns>
        public static T DeserializeXML<T>(string s)
        {
            
            T t; //We will use the as the return value      
            
            using (FileStream fs = File.OpenRead(s + ".xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                t = (T)deserializer.Deserialize(fs);                
                fs.Close();
            }

            return t;
        }

    }
}
