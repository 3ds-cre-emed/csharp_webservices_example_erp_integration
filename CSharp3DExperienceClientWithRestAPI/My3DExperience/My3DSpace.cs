using CSharp3DExperienceClientWithRestAPI.My3DExperience.JsonResponses;
using Newtonsoft.Json;
using RestSharp;

namespace CSharp3DExperienceClientWithRestAPI.My3DExperience
{
    class My3DSpace
    {
        /* Public Variables */
        public My3DPassport myPassport { get; set; }

        /* Local Variables */
        private string baseURL = new AppEnvironment.My3DExperienceURLs().My3DSpace;
        private string tenant = new AppEnvironment.My3DExperienceURLs().MyTenant;
        
        /* Search in CAD Collaboration */
        public XCADSearchResult Search_CADCollaboration(string searchString, string dsxcad = "dsxcad:Product", int top = 200, int skip = 0)
        {
            string url = baseURL + "/resources/v1/modeler/dsxcad/"+ dsxcad +"/Search";

            /* Request */
            RestRequest req = new RestRequest(url, Method.GET, DataFormat.Json);

            /* Headers */
            req.AddHeader("Content-Type", "application/json");
            req.AddHeader("Accept", "application/json");
            req.AddHeader("SecurityContext", myPassport.SecurityContext);

            /* Query Parameters */
            req.AddQueryParameter("tenant", tenant);
            req.AddQueryParameter("$mask", "dsmvxcad:xCADRepMask.Details");
            req.AddQueryParameter("$top", top.ToString());
            req.AddQueryParameter("$skip", skip.ToString());
            req.AddQueryParameter("$searchStr", searchString);

            /* Response */
            IRestResponse res = myPassport.MyClient.Execute(req);

            /* Convert to Obj */
            XCADSearchResult result = JsonConvert.DeserializeObject<XCADSearchResult>(res.Content);

            return result;
        }
    }
}
