using System.Xml;

namespace PardotAPI
{
    public class account : PardotAPI.@object
    {
        public string id { get; set; }
        public string company { get; set; }
        public string level { get; set; }
        public string website { get; set; }
        public string vanity_domain { get; set; }
        public string plugin_campaign_id { get; set; }
        public string tracking_code_template { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string territory { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

        public account() { }
        public account(XmlNode source) { loadObject(source); }
    }
}