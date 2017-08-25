using System;
using System.Xml;

namespace PardotAPI
{
    public class emailTemplate : PardotAPI.@object
    {
        //TODO
        public string id { get; set; }


        public emailTemplate() { throw new NotImplementedException(); }
        public emailTemplate(XmlNode source) { loadObject(source); }
    }
}
