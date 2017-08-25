﻿using System.Xml;

namespace PardotAPI
{
    public class customField : PardotAPI.@object
    {
        public string id { get; set; }
        public string name { get; set; }
        public string field_id { get; set; }
        public string type { get; set; }
        public string type_id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string is_record_multiple_responses { get; set; }
        public string crm_id { get; set; }
        public string is_use_values { get; set; }

        public customField() { }
        public customField(XmlNode source) { loadObject(source); }
    }
}