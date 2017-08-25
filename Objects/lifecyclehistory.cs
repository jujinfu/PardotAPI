using System.Xml;

namespace PardotAPI
{
    public class lifecycleHistory : PardotAPI.@object
    {
        public string id { get; set; }
        public string prospect_id { get; set; }
        public string previous_stage_id { get; set; }
        public string next_stage_id { get; set; }
        public string seconds_elapsed { get; set; }
        public string created_at { get; set; }

        public lifecycleHistory() { }
        public lifecycleHistory(XmlNode source) { loadObject(source);}
    }
}