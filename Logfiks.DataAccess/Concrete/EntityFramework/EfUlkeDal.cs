﻿using Logfiks.DataAccess.Abstract;
using LogFiks.Core.DataAccess.EntityFramework;
using LogFiks.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logfiks.DataAccess.Concrete.EntityFramework
{
    public class EfUlkeDal : EfEntityRepositoryBase<Ulke, ZeusContext>, IUlkeDal
    {

    }
}
