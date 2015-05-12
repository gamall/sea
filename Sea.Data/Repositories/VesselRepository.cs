using Sea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sea.Core.Contracts.Data;
using System.Data.Entity;

namespace Sea.Data.Repositories
{
    public class VesselRepository : EFRepository<Vessel>, IVesselRepository
    {
        public VesselRepository(DbContext context) : base(context)
        {            
        }

        public IQueryable<Vessel> GetVessels()
        {
            return DbSet;
        }

        public Vessel GetVessel(Guid VesselGUID)
        {
            return DbSet.FirstOrDefault(o => o.VesselGUID == VesselGUID);
        }
    }
}
