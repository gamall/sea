using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea.Core.Contracts.Data
{
    public interface ISeaUow
    {
        void Commit();

        IVesselRepository Vessel { get; }
        IVesselDocumentRepository VesselDocument { get; }
    }
}
