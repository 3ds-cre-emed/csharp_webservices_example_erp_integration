using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3DExperienceClientWithRestAPI.My3DExperience.JsonResponses
{
    // XCADSearchResult myDeserializedClass = JsonConvert.DeserializeObject<XCADSearchResult>(myJsonResponse);
    public class DsxcadXCADAttributes
    {
        public string cadorigin { get; set; }
    }

    public class Member
    {
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string modified { get; set; }
        public string created { get; set; }
        public string revision { get; set; }
        public string state { get; set; }
        public string owner { get; set; }
        public string organization { get; set; }
        public string collabspace { get; set; }

        [JsonProperty("dsxcad:xCADAttributes")]
        public DsxcadXCADAttributes dsxcadxCADAttributes { get; set; }
        public string cestamp { get; set; }
    }

    public class NlsLabel
    {
        public string id { get; set; }
        public string type { get; set; }
        public string modified { get; set; }
        public string created { get; set; }
        public string revision { get; set; }
        public string state { get; set; }
        public string owner { get; set; }

        [JsonProperty("dsxcad:xCADAttributes")]
        public string dsxcadxCADAttributes { get; set; }
        public string cadtype { get; set; }

        [JsonProperty("dsxcad:AuthoringFile")]
        public string dsxcadAuthoringFile { get; set; }
    }

    public class XCADSearchResult
    {
        public int totalItems { get; set; }
        public List<Member> member { get; set; }
        public NlsLabel nlsLabel { get; set; }
    }



}
