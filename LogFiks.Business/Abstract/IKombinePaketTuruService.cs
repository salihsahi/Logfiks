using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface IKombinePaketTuruService
    {
        List<KombinePaketTuru> GetAll();
        void Add(KombinePaketTuru kombinePaketTuru);
        void Update(KombinePaketTuru kombinePaketTuru);
        void Delete(int id);
        KombinePaketTuru GetById(int id);
    }
}
