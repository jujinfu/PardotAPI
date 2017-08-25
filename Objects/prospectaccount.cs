using System.Xml;

namespace PardotAPI
{
    public class prospectAccount : PardotAPI.@object
    {
        public string id { get; set; }
        public string name { get; set; }

        public prospectAccount() { }
        public prospectAccount(XmlNode source) { loadObject(source);}
    }
}
 