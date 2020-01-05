using LogFiks.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LogFiks.Entities.Concrete
{
    public class ApiKullanicilari : IEntity
    {
        [Key]
        public int id { get; set; }
        public int firmaid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
