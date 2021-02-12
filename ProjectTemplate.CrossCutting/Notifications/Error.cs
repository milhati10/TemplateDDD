using System.Collections.Generic;
using System.Net;

namespace ProjectTemplate.InfraEstructure.CrossCutting.Notifications
{
    public class Error
    {
        public IEnumerable<string> Messages { get; set; }
        public int Status { get; set; }

        public Error(IEnumerable<string> msg, HttpStatusCode code)
        {
            Messages = msg;
            Status = (int)code;
        }
    }
}
