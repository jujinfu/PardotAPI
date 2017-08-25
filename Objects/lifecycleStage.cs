using System.Xml;

namespace PardotAPI
{
    public class lifecycleStage : PardotAPI.@object
    {
        public string id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string is_locked { get; set; }

        public lifecycleStage() { }
        public lifecycleStage(XmlNode source) { loadObject(source);}
    }
}