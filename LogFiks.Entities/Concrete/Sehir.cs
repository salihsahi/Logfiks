using LogFiks.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace LogFiks.Entities.Concrete
{
    [Table("ilceler")]
    public class Sehir : IEntity
    {
        [Key]
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("il_kodu")]
        public int IlKodu { get; set; }
        [DataMember]
        [Column("il_adi")]
        public string IlAdi { get; set; }
    }
}
