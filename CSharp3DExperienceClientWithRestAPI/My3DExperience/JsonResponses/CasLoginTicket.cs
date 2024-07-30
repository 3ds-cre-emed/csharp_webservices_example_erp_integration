using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3DExperienceClientWithRestAPI.My3DExperience.JsonResponses
{
    // CasTicket myDeserializedClass = JsonConvert.DeserializeObject<CasTicket>(myJsonResponse);
    public class CasLoginTicket
    {
        public string response { get; set; }
        public string lt { get; set; }
    }
}
