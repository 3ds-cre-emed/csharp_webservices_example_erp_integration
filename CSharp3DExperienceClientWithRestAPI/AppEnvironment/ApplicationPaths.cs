using System;

namespace CSharp3DExperienceClientWithRestAPI.AppEnvironment
{
    class ApplicationPaths
    {
        /* Desktop */
        public String Desktop => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        /* External System Database Path */
        public String DBFolder => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        /* External System DB Name */
        public String DBName => "myData.json";
    }
}
