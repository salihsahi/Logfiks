using Logfiks.DataAccess.Abstract;
using LogFiks.Business.Abstract;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogFiks.Business.Concrete
{
    public class YapisalOzellikManager : IYapisalOzellikService
    {

        private IYapisalOzellikDal _YapisalOzellikDal;

        public YapisalOzellikManager(IYapisalOzellikDal YapisalOzellikDal)
        {
            _YapisalOzellikDal = YapisalOzellikDal;
        }

        public void Add(YapisalOzellik tasitTipi)
        {
            _YapisalOzellikDal.Add(tasitTipi);
        }

        public void Delete(int id)
        {
            _YapisalOzellikDal.Delete(new YapisalOzellik { Id = id });
        }

        public List<YapisalOzellik> GetAll()
        {
            return _YapisalOzellikDal.GetList();
        }

        public YapisalOzellik GetById(int id)
        {
            return _YapisalOzellikDal.Get(p => p.Id == id);
        }

        public void Update(YapisalOzellik tasitTipi)
        {
            _YapisalOzellikDal.Update(tasitTipi);
        }
    }
}
