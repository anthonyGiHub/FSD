using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] GetOpeningJobs()
        {
            string[] openingJobs = new string[] { "Webapi", "dotnet", "fsd", "pmo" };
            return openingJobs;
        }

        public string[] GetOpeningJobsByRole(string value)
        {
            string[] openingJobbyrole = new string[] { };
            if (value == "Developer")
            {
                openingJobbyrole = new string[] { "Webapideveloper", "dotnetdeveloper", "fsddeveloper" };
            }
            else if (value == "Manager")
            {
                openingJobbyrole = new string[] { "DeliveryMangager", "SenioirManager" };
            }
            else
            {
                openingJobbyrole = new string[] { "No job found for this role" };
            }
            return openingJobbyrole;
        }
    }
}
