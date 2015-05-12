using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Sea.Web.Models
{
    public class VesselModels
    {
        public Guid VesselGUID { get; set; }
        public string VesselName { get; set; }
    }

    public class VesselDocumentModels
    {
        public Guid VesselGUID { get; set; }
        public string VesselName { get; set; }
        public int DocCount { get; set; }
    }

}