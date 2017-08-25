using System.Xml;

namespace PardotAPI
{
    public class visitorActivity : PardotAPI.@object
    {
        public string id { get; set; }
        public string prospect_id { get; set; }
        public string visitor_id { get; set; }
        public string type { get; set; }
        public string type_name { get; set; }
        public string details { get; set; }
        public string email_id { get; set; }
        public string email_template_id { get; set; }
        public string created_at { get; set; }

        public visitorActivity() { }
        public visitorActivity(XmlNode source) { loadObject(source);}
    }
}