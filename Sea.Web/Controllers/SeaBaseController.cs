using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sea;
using Sea.Core;
using Sea.Core.Contracts.Data;

namespace Sea.Web.Controllers
{
    public class SeaBaseController : Controller
    {
        protected ISeaUow Uow { get; set; }
    }
}
