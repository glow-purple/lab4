using System;
using System.IO;
using System.Xml.Serialization;

namespace Lab4.Model
{
    public static class Serializer
    {
        public static void ToXml<T>(T itemDto, string path)
        {
            if (itemDto == null)
                throw new ArgumentNullException();
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException();
            XmlSerializer orgSerializer = new
                XmlSerializer(typeof(T));
            using (StreamWriter writer = new StreamWriter(path))
            {
                orgSerializer.Serialize(writer, itemDto);
            }
        }
        public static T FromXml<T>(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException();
            T item;
            XmlSerializer orgSerializer = new
        XmlSerializer(typeof(T));
            using (StreamReader reader = new StreamReader(path))
            {
                item = (T)orgSerializer.Deserialize(reader);
            }
            return item;
        }
    }
}