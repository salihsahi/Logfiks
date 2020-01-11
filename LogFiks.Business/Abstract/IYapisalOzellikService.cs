using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Abstract
{
    public interface IYapisalOzellikService
    {
        List<YapisalOzellik> GetAll();
        void Add(YapisalOzellik tasitTipi);
        void Update(YapisalOzellik tasitTipi);
        void Delete(int id);
        YapisalOzellik GetById(int id);
    }
}
