﻿using System.Xml;

namespace PardotAPI
{
    public class form : PardotAPI.@object
    {
        public string id { get; set; }
        public string name { get; set; }
        public string campaign { get; set; }
        public string embedCode { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

        public form() { }
        public form(XmlNode source) { loadObject(source);}
    }
}