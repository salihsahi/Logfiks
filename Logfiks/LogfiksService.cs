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


        public LogfiksService(ITasitTipiService TasitTipiService, IApiKullanicilariService ApiKullanicilariService)
        {
            _TasitTipiService = TasitTipiService;
            _ApiKullanicilariService = ApiKullanicilariService;
        }

        public List<TasitTipi> TasitTipleri(TasitTipleriRequest request)
        {
            if (_ApiKullanicilariService.Login(request.AuthenticationHeader.Username, request.AuthenticationHeader.Password))
            {
                return _TasitTipiService.GetAll();
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
