using LogFiks.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace LogFiks.Entities.Concrete
{
    [Table("sevkiyat_tipleri")]
    public class SevkiyatTipi : IEntity
    {
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("adi")]
        public string Adi { get; set; }
    }
}
