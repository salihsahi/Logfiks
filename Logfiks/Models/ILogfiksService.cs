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
        List<TasitTipi> TasitTipleriGetir(TasitTipleriRequest s2);

        [OperationContract]
        List<YapisalOzellik> YapisalOzellikGetir(YapisalOzellikRequest s2);

        [OperationContract]
        List<Ulke> UlkeGetir(UlkeRequest s2);

        /*
        [OperationContract]
        List<Sehir> SehirGetir(SehirRequest s2);
        */

        [OperationContract]
        List<Ilce> IlceGetir(IlceRequest s2);


        [OperationContract]
        List<KombinePaketTuru> KombinePaketTuruGetir(KombinePaketTuruRequest s2);


        [OperationContract]
        List<TekliPaketTuru> TekliPaketTuruGetir(TekliPaketTuruRequest s2);


        [OperationContract]
        List<SevkiyatTipi> SevkiyatTipiGetir(SevkiyatTipiRequest s2);

    }
}