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
    class DataSerialization
    {
        private static object serilaizer;

        public static void Serialize(string fileName T data)
        {
            XmlSerializer serilize = new XmlSerializer(typeof(T));
            TextWriter writter = new StreamWriter(@"..\..\SavedFiles\"+ fileName + ".xml");
            serilaizer.Serialize(writter, data);

            writter.Close();


        }


    }
}
