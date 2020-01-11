using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Concrete
{
    public class UlkeManager : IUlkeService
    {

        private IUlkeDal _UlkeDal;

        public UlkeManager(IUlkeDal UlkeDal)
        {
            _UlkeDal = UlkeDal;
        }

        public void Add(Ulke ulke)
        {
            _UlkeDal.Add(ulke);
        }

        public void Delete(int id)
        {
            _UlkeDal.Delete(new Ulke { Id = id });
        }

        public List<Ulke> GetAll()
        {
            return _UlkeDal.GetList();
        }

        public Ulke GetById(int id)
        {
            return _UlkeDal.Get(p => p.Id == id);
        }

        public void Update(Ulke ulke)
        {
            _UlkeDal.Update(ulke);
        }
    }
}
