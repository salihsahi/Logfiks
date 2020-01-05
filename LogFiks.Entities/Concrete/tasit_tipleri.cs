using LogFiks.Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace LogFiks.Entities.Concrete
{

    [DataContract(Namespace ="")]
    [Table("tasit_tipleri")]
    public class TasitTipi: IEntity
    {
        [DataMember]
        [Column("id")]
        public int Id { get; set; }
        [DataMember]
        [Column("adi")]
        public string Adi { get; set; }
        [IgnoreDataMember,XmlIgnore]
        public int sira { get; set; }
    }

}
