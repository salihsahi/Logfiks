using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface IApiKullanicilariService
    {
        List<ApiKullanicilari> GetAll();
        void Add(ApiKullanicilari ApiKullanicisi);
        void Update(ApiKullanicilari ApiKullanicisi);
        void Delete(int id);
        ApiKullanicilari GetById(int id);
        bool Login(string Username, string Password);
    }
}
