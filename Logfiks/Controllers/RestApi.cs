using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logfiks.Models;
using Logfiks.Models.SoapRequests;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Logfiks.Controllers
{
    [Route("RestApi/")]
    [ApiController]
    public class RestApi : Controller
    {
        private ITasitTipiService _TasitTipiService;
        private IYapisalOzellikService _YapisalOzellikService;
        private IUlkeService _UlkeService;

        //private ISehirService _SehirService;
        private IIlceService _IlceService;
        private IKombinePaketTuruService _KombinePaketTuruService;
        private ITekliPaketTuruService _TekliPaketTuruService;
        private ISevkiyatTipiService _SevkiyatTipiService;

        public RestApi(ITasitTipiService TasitTipiService, IYapisalOzellikService YapisalOzellikService, IUlkeService UlkeService
            //, ISehirService SehirService
            , IIlceService IlceService
            , IKombinePaketTuruService KombinePaketTuruService
            , ITekliPaketTuruService TekliPaketTuruService
            , ISevkiyatTipiService SevkiyatTipiService)
        {
            _TasitTipiService = TasitTipiService;
            _YapisalOzellikService = YapisalOzellikService;
            _UlkeService = UlkeService;

            //_SehirService = SehirService;
            _IlceService = IlceService;
            _KombinePaketTuruService = KombinePaketTuruService;
            _TekliPaketTuruService = TekliPaketTuruService;
            _SevkiyatTipiService = SevkiyatTipiService;
        }

        [HttpGet]
        [Route("start")]
        public ApiResponse start()
        {
            string result = "Logfiks Api Status : True";
            return AddResponseAttr(result);
        }


        [HttpPost]
        [Route("TasitTipleriGetir")]
        public ApiResponse Gettasit_listesi(TasitTipleriRequest s2)
        {
            List<TasitTipi> TasitListesi = _TasitTipiService.GetAll();
            return AddResponseAttr(TasitListesi);
        }


        [HttpPost]
        [Route("YapisalOzellikGetir")]
        public ApiResponse GetYapisalOzellik(YapisalOzellikRequest s2)
        {
            List<YapisalOzellik> YapisalOzellik = _YapisalOzellikService.GetAll();
            return AddResponseAttr(YapisalOzellik);
        }


        [HttpPost]
        [Route("UlkeGetir")]
        public ApiResponse GetUlke(YapisalOzellikRequest s2)
        {
            List<Ulke> Ulke = _UlkeService.GetAll();
            return AddResponseAttr(Ulke);
        }


        /*
        [HttpPost]
        [Route("SehirGetir")]
        public ApiResponse GetSehir(SehirRequest s2)
        {
            List<Sehir> Sehir = _SehirService.GetAll();
            return AddResponseAttr(Sehir);
        }
        */


        [HttpPost]
        [Route("IlceGetir")]
        public ApiResponse GetIlce(IlceRequest s2)
        {
            List<Ilce> Ilce = _IlceService.GetAll(s2.IlKodu);
            return AddResponseAttr(Ilce);
        }


        [HttpPost]
        [Route("KombinePaketTuruGetir")]
        public ApiResponse GetKombinePaketTuru(KombinePaketTuruRequest s2)
        {
            List<KombinePaketTuru> KombinePaketTuru = _KombinePaketTuruService.GetAll();
            return AddResponseAttr(KombinePaketTuru);
        }


        [HttpPost]
        [Route("TekliPaketTuruGetir")]
        public ApiResponse GetTekliPaketTuru(TekliPaketTuruRequest s2)
        {
            List<TekliPaketTuru> TekliPaketTuru = _TekliPaketTuruService.GetAll();
            return AddResponseAttr(TekliPaketTuru);
        }


        [HttpPost]
        [Route("SevkiyatTipiGetir")]
        public ApiResponse GetSevkiyatTipi(SevkiyatTipiRequest s2)
        {
            List<SevkiyatTipi> SevkiyatTipi = _SevkiyatTipiService.GetAll();
            return AddResponseAttr(SevkiyatTipi);
        }


        public ApiResponse AddResponseAttr(object model, bool isSuccess = true, string message = "")
        {
            try { return new ApiResponse { Data = model, IsSuccess = isSuccess, Message = message }; }
            catch (Exception ex) { return new ApiResponse { Data = ex.Message, IsSuccess = false }; }
        }


    }
}
