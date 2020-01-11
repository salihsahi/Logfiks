using Logfiks.Models;
using Logfiks.Models.SoapRequests;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Logfiks
{
    public class LogfiksService : ILogfiksService
    {
        private ITasitTipiService _TasitTipiService;
        private IApiKullanicilariService _ApiKullanicilariService;
        private IYapisalOzellikService _YapisalOzellikService;
        private IUlkeService _UlkeService;

        //private ISehirService _SehirService;
        private IIlceService _IlceService;
        private IKombinePaketTuruService _KombinePaketTuruService;
        private ITekliPaketTuruService _TekliPaketTuruService;
        private ISevkiyatTipiService _SevkiyatTipiService;


        public LogfiksService(ITasitTipiService TasitTipiService, IApiKullanicilariService ApiKullanicilariService, IYapisalOzellikService YapisalOzellikService, IUlkeService UlkeService

            //, ISehirService SehirService
            , IIlceService IlceService
            , IKombinePaketTuruService KombinePaketTuruService
            , ITekliPaketTuruService TekliPaketTuruService
            , ISevkiyatTipiService SevkiyatTipiService
            )
        {
            _TasitTipiService = TasitTipiService;
            _ApiKullanicilariService = ApiKullanicilariService;
            _YapisalOzellikService = YapisalOzellikService;
            _UlkeService = UlkeService;

            //_SehirService = SehirService;
            _IlceService = IlceService;
            _KombinePaketTuruService = KombinePaketTuruService;
            _TekliPaketTuruService = TekliPaketTuruService;
            _SevkiyatTipiService = SevkiyatTipiService;
        }

        public List<TasitTipi> TasitTipleriGetir(TasitTipleriRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _TasitTipiService.GetAll();
            }
            return null;   
        }


        public List<YapisalOzellik> YapisalOzellikGetir(YapisalOzellikRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _YapisalOzellikService.GetAll();
            }
            return null;
        }


        public List<Ulke> UlkeGetir(UlkeRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _UlkeService.GetAll();
            }
            return null;
        }


        /*
        public List<Sehir> SehirGetir(SehirRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _SehirService.GetAll();
            }
            return null;
        }
        */


        public List<Ilce> IlceGetir(IlceRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _IlceService.GetAll(request.IlKodu);
            }
            return null;
        }



        public List<KombinePaketTuru> KombinePaketTuruGetir(KombinePaketTuruRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _KombinePaketTuruService.GetAll();
            }
            return null;
        }



        public List<TekliPaketTuru> TekliPaketTuruGetir(TekliPaketTuruRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _TekliPaketTuruService.GetAll();
            }
            return null;
        }



        public List<SevkiyatTipi> SevkiyatTipiGetir(SevkiyatTipiRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _SevkiyatTipiService.GetAll();
            }
            return null;
        }

        public SoapResult AddSoapResult(object model, bool isSuccess = true, string message = "")
        {
            try { return new SoapResult { Data = model, IsSuccess = isSuccess, Message = message }; }
            catch (Exception ex) { return new SoapResult { Data = ex.Message, Message = ex.Message, IsSuccess = false }; }
        }


    }
}
