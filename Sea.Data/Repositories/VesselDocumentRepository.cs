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
    public class VesselDocumentRepository : EFRepository<VesselDocument>, IVesselDocumentRepository
    {
        public VesselDocumentRepository(DbContext context)
            : base(context)
        {            
        }

        public IQueryable<VesselDocument> GetVesselDocuments()
        {
            return DbSet;
        }

        public VesselDocument GetVesselDocument(Guid DocGUID)
        {
            return DbSet.FirstOrDefault(o => o.DocGUID == DocGUID);
        }
    }
}
