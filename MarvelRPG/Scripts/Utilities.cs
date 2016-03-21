using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Yaml.Serialization;
using System;
using System.IO;
using System.Xml.Serialization;

namespace MarvelRPG
{
    public static class Utilities
    {
        public static void Serialize<T>(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\..\SavedFiles\" + s + ".xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(fs, t);
                fs.Close();
            }
        }
        public static void SerializeBinary<T>(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\..\SavedFiles\" + s + ".bin")) //Creates a FileStream using information from the file we created
            {
                BinaryFormatter serializer = new BinaryFormatter(); //Creates a new BinaryFormatter to give us access to the Serialize function
                //We call the Serialize method and pass in the FileStream we created and the data inside of the object we passed into the function
                //When the data is being serialized it is being wrote into the created file in the form of bits and bytes there for if you open up the
                //file it is not human readable with the exception of the variables we declared.
                //To have the file in a human readable form we would use the SoapFormatter method
                serializer.Serialize(fs, t);
                fs.Close(); //Allways close your files when you are done using them
            }
        }

        public static T DeserializeBinary<T>(string s)
        {
            T t; //We will use the as the return value
            using (FileStream fs = File.OpenRead(@"..\..\SavedFiles\" + s + ".bin")) //Same process as Serialize but instead of create we use OpenRead
            {
                BinaryFormatter deserializer = new BinaryFormatter(); //Creates a new binaryFormatter that will give us access to the Deseralize function
                                                                      //We then call the Deserialize method and give it the arguments of the FileStream we created that contains all the data inside of the file
                                                                      //we opened and are reading from.
                                                                      //We take all this information and cast it as the return type and then set the variable we created at the head of the function equal to the
                                                                      //value of the Deseaialize method
                t = (T)deserializer.Deserialize(fs);
                fs.Close(); //Allways close your files when you are done using them
            }
            return t; //We then return t
        }

        public static void SerializeSoap<T>(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\..\SavedFiles\" + s + ".xml"))
            {
                SoapFormatter serializer = new SoapFormatter();
                serializer.Serialize(fs, t);
                fs.Close();
            }
        }

        public static T DeserializeSoap<T>(string s)
        {
            T t;
            using (FileStream fs = File.OpenRead(@"..\..\SavedFiles\" + s + ".xml"))
            {
                SoapFormatter deserializer = new SoapFormatter();

                t = (T)deserializer.Deserialize(fs);
                fs.Close();
            }
            return t;
        }

        public static void SerializeXML<T>(string s, T t)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = path + @"\My Games\"+System.Windows.Forms.Application.ProductName;
            if (Directory.Exists(path))
            {
                using (FileStream fs = File.Create(path + s + ".xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(fs, t);
                    fs.Close();
                }
            }
            else
            {
                string appName = System.Windows.Forms.Application.ProductName;
                Directory.CreateDirectory(Path.Combine(path, @"\MarvelRPG\"));
            }

        }

        public static T DeserializeXML<T>(string s)
        {
            T t; //We will use the as the return value
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games");


            using (FileStream fs = File.OpenRead(path + s + ".xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));

                t = (T)deserializer.Deserialize(fs);
                fs.Close();
            }
            return t;
        }

    }
}
