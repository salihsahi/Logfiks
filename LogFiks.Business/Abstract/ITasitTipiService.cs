using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface ITasitTipiService
    {
        List<TasitTipi> GetAll();
        void Add(TasitTipi tasitTipi);
        void Update(TasitTipi tasitTipi);
        void Delete(int id);
        TasitTipi GetById(int id);
    }
}
