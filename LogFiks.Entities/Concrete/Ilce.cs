using LogFiks.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace LogFiks.Entities.Concrete
{
    [Table("ilceler")]
    public class Ilce: IEntity
    {
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("adi")]
        public int Adi { get; set; }
        [DataMember]
        [Column("ilce_adi")]
        public string IlceAdi { get; set; }

        [IgnoreDataMember, XmlIgnore]
        [Column("il_kodu")]
        public int IlKodu { get; set; }
    }
}
