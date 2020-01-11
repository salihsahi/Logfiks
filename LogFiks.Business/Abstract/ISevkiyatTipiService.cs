using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface ISevkiyatTipiService
    {
        List<SevkiyatTipi> GetAll();
        void Add(SevkiyatTipi ulke);
        void Update(SevkiyatTipi ulke);
        void Delete(int id);
        SevkiyatTipi GetById(int id);
    }
}
