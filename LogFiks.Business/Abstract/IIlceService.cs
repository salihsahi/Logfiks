using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface IIlceService
    {
        List<Ilce> GetAll(int IlKodu);
        void Add(Ilce ilce);
        void Update(Ilce ilce);
        void Delete(int id);
        Ilce GetById(int id);
    }
}
