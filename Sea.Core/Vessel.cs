using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea.Core
{
    [Table("Vessel")]
    public class Vessel
    {
        [Key]
        [Column("VesselGUID")]
        public Guid VesselGUID { get; set; }
        [Column("Name")]
        public string Name { get; set; }

        public virtual ICollection<VesselDocument> VesselDocuments { get; set; }
    }
}