using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Concrete
{
    public class IlceManager : IIlceService
    {

        private IIlceDal _IlceDal;

        public IlceManager(IIlceDal IlceDal)
        {
            _IlceDal = IlceDal;
        }

        public void Add(Ilce Ilce)
        {
            _IlceDal.Add(Ilce);
        }

        public void Delete(int id)
        {
            _IlceDal.Delete(new Ilce { Id = id });
        }

        public List<Ilce> GetAll(int IlKodu)
        {
            return _IlceDal.GetList(p => p.IlKodu == IlKodu);
        }

        public Ilce GetById(int id)
        {
            return _IlceDal.Get(p => p.Id == id);
        }

        public void Update(Ilce Ilce)
        {
            _IlceDal.Update(Ilce);
        }
    }
}
