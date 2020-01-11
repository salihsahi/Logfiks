using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Concrete
{
    public class TekliPaketTuruManager : ITekliPaketTuruService
    {

        private ITekliPaketTuruDal _TekliPaketTuruDal;

        public TekliPaketTuruManager(ITekliPaketTuruDal TekliPaketTuruDal)
        {
            _TekliPaketTuruDal = TekliPaketTuruDal;
        }

        public void Add(TekliPaketTuru TekliPaketTuru)
        {
            _TekliPaketTuruDal.Add(TekliPaketTuru);
        }

        public void Delete(int id)
        {
            _TekliPaketTuruDal.Delete(new TekliPaketTuru { Id = id });
        }

        public List<TekliPaketTuru> GetAll()
        {
            return _TekliPaketTuruDal.GetList();
        }

        public TekliPaketTuru GetById(int id)
        {
            return _TekliPaketTuruDal.Get(p => p.Id == id);
        }

        public void Update(TekliPaketTuru TekliPaketTuru)
        {
            _TekliPaketTuruDal.Update(TekliPaketTuru);
        }

       
    }
}
