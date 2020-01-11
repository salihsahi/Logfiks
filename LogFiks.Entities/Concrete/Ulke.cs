using LogFiks.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace LogFiks.Entities.Concrete
{
    [Table("tasit_tipleri")]
    public class Ulke : IEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("kod")]
        public string Kod { get; set; }
        [DataMember]
        [Column("ulke_adi")]
        public string UlkeAdi { get; set; }
    }
}
