using LogFiks.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace LogFiks.Entities.Concrete
{
    [Table("tekli_paket_turleri")]
    public class TekliPaketTuru : IEntity
    {
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("paket_turu")]
        public string PaketTuru { get; set; }
    }
}
