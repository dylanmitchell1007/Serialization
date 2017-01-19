using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialize
{
    class DataSerialization <T>
    { 

        public static void Serialize(string fileName, T data)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(T));
            TextWriter writter = new StreamWriter(@"..\..\SavedFiles\"+ fileName + ".xml");
            serialize.Serialize(writter, data);

            writter.Close();

        }

        public static T Deserialize(string fileName)
        {
            T data;

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            TextReader reader = new StreamReader(@"..\")

        }
    }
}
