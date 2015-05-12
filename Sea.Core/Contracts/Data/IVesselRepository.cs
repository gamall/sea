using Sea.Core;
using System;
using System.Linq;

namespace Sea.Core.Contracts.Data
{
    public interface IVesselRepository : IRepository<Vessel>
    {
        IQueryable<Vessel> GetVessels();

        Vessel GetVessel(Guid VesselGUID);
    }
}
