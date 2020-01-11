using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface ISehirService
    {
        List<Sehir> GetAll();
        void Add(Sehir sehir);
        void Update(Sehir sehir);
        void Delete(int id);
        Sehir GetById(int id);
    }
}
