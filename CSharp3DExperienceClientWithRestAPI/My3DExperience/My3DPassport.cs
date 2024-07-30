using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;
using CSharp3DExperienceClientWithRestAPI.AppEnvironment;
using static CSharp3DExperienceClientWithRestAPI.My3DExperience.JsonResponses.CasLoginTicket;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web;
using CSharp3DExperienceClientWithRestAPI.My3DExperience.JsonResponses;

namespace CSharp3DExperienceClientWithRestAPI.My3DExperience
{
    class My3DPassport
    {
        /* Global Variables */
        public RestClient MyClient { get; set; }
        public string LoginTicket { get; set; }
        public UserPrefferedCredentials UserPrefs { get; set; }
        public string SecurityContext { get; set; }

        string urlPassport = "";

        // -------------Step.1: Create client for 3DPassport
        public RestClient set_client()
        {
            /* Save Base URL */
            urlPassport = new My3DExperienceURLs().My3DPassport;

            /* Create a new Client */
            MyClient = new RestClient(urlPassport);
            MyClient.CookieContainer = new CookieContainer();
            MyClient.Timeout = -1;

            return MyClient;
        }

        // -------------Step.1.1: Get created client, u can use after this
        public RestClient get_client()
        {
            return MyClient;
        }

        // -------------Step.2: Now have to get login ticket for 3DExperience (Method: GET)
        public string get_login_ticket(RestClient created_client)
        {
            string url =  urlPassport +  "/login";

            /* Create a new Request */
            RestRequest request = new RestRequest(url, Method.GET);
            request.AddQueryParameter("action", "get_auth_params");
            request.AddHeader("Accept", "application/json");

            /* Send request */
            IRestResponse responseTicket =  created_client.Execute(request); 

            /* Serialize Response */
            JObject res = JObject.Parse(responseTicket.Content);

            return res["lt"].ToString();
        }

        // -------------Step.3: This function is redirecting to 3DSpace platform
        public UserPrefferedCredentials redirect_to_3DSpace(RestClient created_client, string lt, string username, string password, Boolean rememberMe)
        {
            string toService = "/login?service=";
            string for3DSpace = "/resources/modeler/pno/person?current=true%26select=collabspaces%26select=preferredcredentials%26tenant=" + new My3DExperienceURLs().MyTenant;
            string urlService = new My3DExperienceURLs().My3DSpace;

            string loginUrl = urlPassport + toService + urlService + for3DSpace; // --------> has to be rebuild loginUrl

            /* Create a new Request */
            RestRequest request = new RestRequest(loginUrl, Method.POST, DataFormat.Json);

            /* x-www-form-encoded json body */
            request.AddParameter("lt", lt);
            request.AddParameter("username", username);
            request.AddParameter("password", password);
            request.AddParameter("rememberMe", rememberMe);

            /* Send request */
            IRestResponse res = created_client.Execute(request);

            /* Serialize Response */
           try
            {
                UserPrefferedCredentials userPrefs = JsonConvert.DeserializeObject<UserPrefferedCredentials>(res.Content);

                return userPrefs;
            } catch
            {
                return null;
            }
        }

        // -------------Step.4: Logout from 3DExperience walking, have a nice day ...
        public bool Logout(RestClient created_client)
        {
            string url = urlPassport + "/logout";

            RestRequest logoutRequest = new RestRequest(url, Method.GET, DataFormat.Json);

            IRestResponse logoutRequestResponse = created_client.Execute(logoutRequest);

            if (logoutRequestResponse.StatusCode == HttpStatusCode.OK)
            {
                return true;
            } else {
                return false;
            }
        }


        // -------------Step.5: Please fill the Security Context for Collaborative Spaces ...
    }
}
