using System.Xml;

namespace PardotAPI
{
    public class visitorReferrer : PardotAPI.@object
    {
        public int id { get; set; }
        public string referrer { get; set; }
        public string vendor { get; set; }
        public string type { get; set; }
        public string query { get; set; }

        public visitorReferrer() { }
        public visitorReferrer(XmlNode source) { loadObject(source);}
    }
}