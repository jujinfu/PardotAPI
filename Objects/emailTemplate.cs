using System;
using System.Xml;

namespace PardotAPI
{
    public class emailTemplate : PardotAPI.@object
    {
        public string id { get; set; }
        public string name { get; set; }
        public string textMessage { get; set; }
        public string isDripEmail { get; set; }
        public string isListEmail { get; set; }
        public string subject { get; set; }
        public string error { set; get; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
        public string sendOptions { get; set; }

        public emailTemplate() { }
        public emailTemplate(XmlNode source) { loadObject(source); }
    }
}
