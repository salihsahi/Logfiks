using LogFiks.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace LogFiks.Entities.Concrete
{
    [Table("tasit_tipleri")]
    public class TasimaSekli : IEntity
    {
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("adi")]
        public string YapisalOzellikAdi { get; set; }
        [IgnoreDataMember, XmlIgnore]
        public int sira { get; set; }
        [IgnoreDataMember, XmlIgnore]
        public string tanim { get; set; }
    }
}
