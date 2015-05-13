using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sea;
using Sea.Core;
using Sea.Core.Contracts.Data;
using Sea.Web.Models;

namespace Sea.Web.Controllers
{
    public class VesselController : SeaBaseController
    {
        public VesselController(ISeaUow uow)
        {
            Uow = uow;
        }

        public ActionResult Index()
        {
            var list = new List<Vessel>();
            if (Uow != null)
            {
                var vessels = Uow.Vessel.GetVessels();
                if (vessels != null)
                    return View(vessels.ToList());
                else
                {
                    
                    var vessel = new Vessel
                    {
                        VesselGUID = Guid.NewGuid(),
                        Name = "Vessel A"
                    };
                    list.Add(vessel);
                    return View(list);
                }
            }
            else
            {
                var vessel = new Vessel {
                    VesselGUID = Guid.NewGuid(),
                    Name = "Vessel B"
                };
                list.Add(vessel);
                return View(list);
            }
        }

        public ActionResult Test()
        {
            return View(Uow.Vessel.GetAll());
        }

        public ActionResult Docs()
        {
            List<VesselDocumentModels> list = new List<VesselDocumentModels>();

            foreach (var doc in Uow.VesselDocument.GetAll().GroupBy(o => new { o.Vessel.VesselGUID, o.Vessel.Name }).ToList())
            {
                VesselDocumentModels vdm = new VesselDocumentModels
                {
                    VesselGUID = doc.Key.VesselGUID,
                    VesselName = doc.Key.Name,
                    DocCount = doc.Count()
                };

                list.Add(vdm);
            }
            return View(list);
        }

        public ActionResult Doc(Guid vesselGUID)
        {
            return View(Uow.VesselDocument.GetAll().FirstOrDefault(o => o.VesselGUID == vesselGUID));
        }

    }
}
