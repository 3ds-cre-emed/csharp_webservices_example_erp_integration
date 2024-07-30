using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3DExperienceClientWithRestAPI.My3DExperience.JsonResponses
{
    public class Collabspace
    {
        public string pid { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public List<Couple> couples { get; set; }
    }

    public class Collabspace2
    {
        public string pid { get; set; }
        public string name { get; set; }
        public string title { get; set; }
    }

    public class Couple
    {
        public Organization organization { get; set; }
        public Role role { get; set; }
    }

    public class Organization
    {
        public string pid { get; set; }
        public string name { get; set; }
        public string title { get; set; }
    }

    public class Preferredcredentials
    {
        public Collabspace collabspace { get; set; }
        public Organization organization { get; set; }
        public Role role { get; set; }
    }

    public class Role
    {
        public string pid { get; set; }
        public string name { get; set; }
        public string nls { get; set; }
    }

    public class UserPrefferedCredentials
    {
        public string pid { get; set; }
        public string name { get; set; }
        public List<Collabspace> collabspaces { get; set; }
        public Preferredcredentials preferredcredentials { get; set; }
    }
}
