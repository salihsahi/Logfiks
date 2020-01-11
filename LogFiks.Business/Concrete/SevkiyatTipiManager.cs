using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Concrete
{
    public class SevkiyatTipiManager : ISevkiyatTipiService
    {

        private ISevkiyatTipiDal _SevkiyatTipiDal;

        public SevkiyatTipiManager(ISevkiyatTipiDal SevkiyatTipiDal)
        {
            _SevkiyatTipiDal = SevkiyatTipiDal;
        }

        public void Add(SevkiyatTipi SevkiyatTipi)
        {
            _SevkiyatTipiDal.Add(SevkiyatTipi);
        }

        public void Delete(int id)
        {
            _SevkiyatTipiDal.Delete(new SevkiyatTipi { Id = id });
        }

        public List<SevkiyatTipi> GetAll()
        {
            return _SevkiyatTipiDal.GetList();
        }

        public SevkiyatTipi GetById(int id)
        {
            return _SevkiyatTipiDal.Get(p => p.Id == id);
        }

        public void Update(SevkiyatTipi SevkiyatTipi)
        {
            _SevkiyatTipiDal.Update(SevkiyatTipi);
        }
    }
}
