using System.Xml;

namespace PardotAPI
{
    public class tagObject : PardotAPI.@object
    {
        public string id { get; set; }
        public string tag_id { get; set; }
        public string type { get; set; }
        public string object_id { get; set; }
        public string created_at { get; set; }

        public tagObject() { }
        public tagObject(XmlNode source) { loadObject(source);}
    }
}