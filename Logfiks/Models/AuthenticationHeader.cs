using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Logfiks.Models
{
    [MessageContract]
    public class AuthenticationHeader
    {
        [MessageHeader(Name = "Username", MustUnderstand = true)]
        public string Username { get; set; }

        [MessageHeader(Name = "Password", MustUnderstand = true)]
        public string Password { get; set; }
    }


    public class IncludeRequest
    {
        [MessageHeader(Name = "AuthenticationHeader", MustUnderstand = true, Namespace = "http://tempuri.org/")]
        [JsonIgnore]
        public AuthenticationHeader AuthenticationHeader { get; set; }
    }

}
