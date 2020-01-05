using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Logfiks.Models
{
    public class ApiResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; }
        public object Data { get; set; }
    }

    [DataContract(Namespace = "")]
    public class SoapResult
    {
        [DataMember]
        public bool IsSuccess { get; set; } = true;
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public object Data { get; set; }
    }


}
