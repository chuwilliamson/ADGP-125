using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace MarvelRPG
{
    public static class Utilities
    {
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


        public static void SerializeXML<T>(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\..\SavedFiles\" + s + ".xml")) //Creates a FileStream using information from the file we created
            {
                SoapFormatter serializer = new SoapFormatter(); //Creates a new BinaryFormatter to give us access to the Serialize function
                //We call the Serialize method and pass in the FileStream we created and the data inside of the object we passed into the function
                //When the data is being serialized it is being wrote into the created file in the form of bits and bytes there for if you open up the
                //file it is not human readable with the exception of the variables we declared.
                //To have the file in a human readable form we would use the SoapFormatter method
                serializer.Serialize(fs, t);
                fs.Close(); //Allways close your files when you are done using them
            }
        }

        public static T DeserializeXML<T>(string s)
        {
            T t; //We will use the as the return value
            using (FileStream fs = File.OpenRead(@"..\..\SavedFiles\" + s + ".xml")) //Same process as Serialize but instead of create we use OpenRead
            {
                SoapFormatter deserializer = new SoapFormatter(); //Creates a new binaryFormatter that will give us access to the Deseralize function
                                                                      //We then call the Deserialize method and give it the arguments of the FileStream we created that contains all the data inside of the file
                                                                      //we opened and are reading from.
                                                                      //We take all this information and cast it as the return type and then set the variable we created at the head of the function equal to the
                                                                      //value of the Deseaialize method
                t = (T)deserializer.Deserialize(fs);
                fs.Close(); //Allways close your files when you are done using them
            }
            return t; //We then return t
        }


    }
}
