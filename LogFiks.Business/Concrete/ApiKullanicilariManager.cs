using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Concrete
{
    public class ApiKullanicilariManager : IApiKullanicilariService
    {

        private IApiKullanicilariDal _ApiKullanicilariDal;

        public ApiKullanicilariManager(IApiKullanicilariDal ApiKullanicilariDal)
        {
            _ApiKullanicilariDal = ApiKullanicilariDal;
        }

        public void Add(ApiKullanicilari ApiKullanicisi)
        {
            _ApiKullanicilariDal.Add(ApiKullanicisi);
        }

        public void Delete(int id)
        {
            _ApiKullanicilariDal.Delete(new ApiKullanicilari { id = id });
        }

        public List<ApiKullanicilari> GetAll()
        {
            return _ApiKullanicilariDal.GetList();
        }

        public ApiKullanicilari GetById(int id)
        {
            return _ApiKullanicilariDal.Get(p => p.id == id);
        }

        public bool Login(string Username, string Password)
        {
            if (_ApiKullanicilariDal.Get(p => p.username == Username && p.password == Password) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(ApiKullanicilari ApiKullanicisi)
        {
            _ApiKullanicilariDal.Update(ApiKullanicisi);
        }
    }
}
