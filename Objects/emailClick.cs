using System.Xml;

namespace PardotAPI
{
    public class emailClick : PardotAPI.@object
    {
        public string id { get; set; }
        public string prospect_id { get; set; }
        public string url { get; set; }
        public string list_email_id { get; set; }
        public string email_template_id { get; set; }
        public string created_at { get; set; }

        public emailClick() { }
        public emailClick(XmlNode source) { loadObject(source); }
    }
}
