using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Logfiks.Models.SoapRequests
{
    [MessageContract]
    public class IlceRequest : IncludeRequest
    {
        [MessageBodyMember]
        public int IlKodu { get; set; }
    }
}
