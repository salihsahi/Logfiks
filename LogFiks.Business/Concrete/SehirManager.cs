using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace LogFiks.Business.Concrete
{
    public class SehirManager : ISehirService
    {

        private ISehirDal _SehirDal;

        public SehirManager(ISehirDal SehirDal)
        {
            _SehirDal = SehirDal;
        }

        public void Add(Sehir Sehir)
        {
            _SehirDal.Add(Sehir);
        }

        public void Delete(int id)
        {
            _SehirDal.Delete(new Sehir { Id = id });
        }

        public List<Sehir> GetAll()
        {
            return _SehirDal.GetList();
            //List<Sehir> asd = _SehirDal.GetList().GroupBy(f => f.IlAdi).Select(g => g.OrderByDescending(s => s.IlAdi).ToList());
            //return asd;
        }

        public Sehir GetById(int id)
        {
            return _SehirDal.Get(p => p.Id == id);
        }

        public void Update(Sehir Sehir)
        {
            _SehirDal.Update(Sehir);
        }
    }
}
