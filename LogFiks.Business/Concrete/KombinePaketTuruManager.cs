using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Concrete
{
    public class KombinePaketTuruManager : IKombinePaketTuruService
    {

        private IKombinePaketTuruDal _KombinePaketTuruDal;

        public KombinePaketTuruManager(IKombinePaketTuruDal KombinePaketTuruDal)
        {
            _KombinePaketTuruDal = KombinePaketTuruDal;
        }

        public void Add(KombinePaketTuru KombinePaketTuru)
        {
            _KombinePaketTuruDal.Add(KombinePaketTuru);
        }

        public void Delete(int id)
        {
            _KombinePaketTuruDal.Delete(new KombinePaketTuru { Id = id });
        }

        public List<KombinePaketTuru> GetAll()
        {
            return _KombinePaketTuruDal.GetList();
        }

        public KombinePaketTuru GetById(int id)
        {
            return _KombinePaketTuruDal.Get(p => p.Id == id);
        }

        public void Update(KombinePaketTuru KombinePaketTuru)
        {
            _KombinePaketTuruDal.Update(KombinePaketTuru);
        }
    }
}
