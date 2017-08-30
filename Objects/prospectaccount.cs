using System.Xml;

namespace PardotAPI
{

    public class prospectAccount : PardotAPI.@object
    {
        public string id { get; set; }
        public string name { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string assigned_to { get; set; }
        public string annual_revenue { get; set; }
        public string billing_address_one { get; set; }
        public string billing_address_two { get; set; }
        public string billing_city { get; set; }
        public string billing_country { get; set; }
        public string billing_state { get; set; }
        public string billing_zip { get; set; }
        public string description { get; set;}
        public string employees { get; set; }
        public string fax { get; set; }
        public string Geo { get; set; }
        public string industry { set; get; }
        public string Install_Base { get; set; }
        public string Market6 { get; set; }
        public string ownership { get; set; }
        public string phone { get; set; }
        public string Partner_Level { get; set; }
        public string Region { get; set; }
        public string shipping_address_one { get; set; }
        public string shipping_address_two { get; set; }
        public string shipping_city { get;set;}
        public string shipping_country { get; set; }
        public string shipping_state { get; set; }    
        public string shipping_zip { get; set; }
        public string sic { get; set; }
        public string Sub_Region { get; set; }
        public string ticker_symbol { get; set; }
        public string type { get; set; }
        public string website { get; set; }
        public string number { get; set; }


        public prospectAccount() { }
        public prospectAccount(XmlNode source) { loadObject(source);}
    }
}
 