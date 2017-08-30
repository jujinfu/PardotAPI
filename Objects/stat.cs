using System.Xml;

namespace PardotAPI
{
    public class stat:@object
    {
        public string sent { get; set; }
        public string delivered { get; set; }
        public string total_clicks { get; set; }
        public string unique_clicks { get; set; }
        public string soft_bounced { get; set; }
        public string hard_bounced { get; set; }
        public string opt_outs { get; set; }
        public string spam_complaints { get; set; }
        public string opens { get; set; }
        public string unique_opens { get; set; }
        public string delivery_rate { get; set; }
        public string opens_rate { get; set; }
        public string click_through_rate { get; set; }
        public string unique_click_through_rate { get; set; }
        public string click_open_ratio { get; set; }
        public string opt_out_rate { get; set; }
        public string spam_complaint_rate { get; set; }

        public stat() { }
        public stat(XmlNode source) { loadObject(source); }


    }
}
