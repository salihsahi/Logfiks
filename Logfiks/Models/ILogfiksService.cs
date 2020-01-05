using Logfiks.Models.SoapRequests;
using LogFiks.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logfiks.Models
{
    [ServiceContract]
    public interface ILogfiksService
    {
        [OperationContract]
        List<TasitTipi> TasitTipleri(TasitTipleriRequest s2);
    }
}