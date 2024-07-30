using System.Collections.Generic;

namespace CSharp3DExperienceClientWithRestAPI.MyPlmData
{

    class ExportInfo
    {
        public string id { get; set; }
        public string creation { get; set; }
        public string modified { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string maturity { get; set; }
        public string owner { get; set; }
        public string revision { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    class PLMExportData
    {
        public int totalItem { get; set; }
        public List<ExportInfo> items {get; set;}
    }
}
