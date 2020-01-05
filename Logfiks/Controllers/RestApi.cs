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

        public RestApi(ITasitTipiService TasitTipiService)
        {
            _TasitTipiService = TasitTipiService;
        }

        [HttpGet]
        [Route("start")]
        public ApiResponse start()
        {
            string result = "Logfiks Api Status : True";
            return AddResponseAttr(result);
        }


        [HttpPost]
        [Route("TasitListesi")]
        public ApiResponse Gettasit_listesi(TasitTipleriRequest s2)
        {
            List<TasitTipi> TasitListesi = _TasitTipiService.GetAll();
            return AddResponseAttr(TasitListesi);
        }

        public ApiResponse AddResponseAttr(object model, bool isSuccess = true, string message = "")
        {
            try { return new ApiResponse { Data = model, IsSuccess = isSuccess, Message = message }; }
            catch (Exception ex) { return new ApiResponse { Data = ex.Message, IsSuccess = false }; }
        }


    }
}
