using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Concrete
{
    public class TasitTipiManager : ITasitTipiService
    {
        private ITasitTipiDal _TasitTipiDal;

        public TasitTipiManager(ITasitTipiDal TasitTipiDal)
        {
            _TasitTipiDal = TasitTipiDal;
        }


        public void Add(TasitTipi tasitTipi)
        {
            _TasitTipiDal.Add(tasitTipi);
        }

        public void Delete(int id)
        {
            _TasitTipiDal.Delete(new TasitTipi { Id = id });
        }

        public List<TasitTipi> GetAll()
        {
            return _TasitTipiDal.GetList();
        }

        public TasitTipi GetById(int id)
        {
            return _TasitTipiDal.Get(p => p.Id == id);
        }

        public void Update(TasitTipi tasitTipi)
        {
            _TasitTipiDal.Update(tasitTipi);
        }
    }
}
