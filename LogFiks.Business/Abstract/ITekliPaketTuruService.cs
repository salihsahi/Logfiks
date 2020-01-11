using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface ITekliPaketTuruService
    {
        List<TekliPaketTuru> GetAll();
        void Add(TekliPaketTuru tekliPaketTuru);
        void Update(TekliPaketTuru tekliPaketTuru);
        void Delete(int id);
        TekliPaketTuru GetById(int id);
    }
}
