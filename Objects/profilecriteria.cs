using System.Xml;

namespace PardotAPI
{
    public class profileCriteria : PardotAPI.@object
    {
        public string id { get; set; }
        public string name { get; set; }
        public string matches { get; set; }

        public profileCriteria() { }
        public profileCriteria(XmlNode source) { loadObject(source);}
    }
}