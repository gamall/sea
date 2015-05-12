using Sea.Core;
using System;
using System.Linq;

namespace Sea.Core.Contracts.Data
{
    public interface IVesselDocumentRepository : IRepository<VesselDocument>
    {
        IQueryable<VesselDocument> GetVesselDocuments();

        VesselDocument GetVesselDocument(Guid DocGUID);
    }
}
