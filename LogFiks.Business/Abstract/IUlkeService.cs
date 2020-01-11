using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface IUlkeService
    {
        List<Ulke> GetAll();
        void Add(Ulke ulke);
        void Update(Ulke ulke);
        void Delete(int id);
        Ulke GetById(int id);
    }
}
