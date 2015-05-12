using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea.Core
{
    [Table("VesselDocument")]
    public class VesselDocument
    {
        [Key]
        [Column("DocGUID")]
        public Guid DocGUID { get; set; }

        [Column("VesselGUID")]
        public virtual Guid VesselGUID { get; set; }
        
        [Column("FileName")]
        public string FileName { get; set; }

        [ForeignKey("VesselGUID")]
        public virtual Vessel Vessel { get; set; }
    }
}