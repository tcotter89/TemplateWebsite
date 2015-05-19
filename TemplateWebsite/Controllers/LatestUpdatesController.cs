using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateWebsite.App_Start;
using TemplateWebsite.Shared.Services;
using TemplateWebsite.Shared.Models;
using TemplateWebsite.ServiceLayer.Services;

namespace TemplateWebsite.Controllers
{
    public class LatestUpdatesController : Controller
    {
        private readonly IUpdatesService _updatesService;

        public LatestUpdatesController() {
            var dependencyInjection = NinjectWebCommon.bootstrapper.Kernel;
            _updatesService = (IUpdatesService)dependencyInjection.GetService(typeof(IUpdatesService));
        }

        public LatestUpdatesController(IUpdatesService updatesService) {
            _updatesService = updatesService;
        }

        public ActionResult Index() {
            List<ModelUpdate> updates = _updatesService.GetAllUpdates();
            ContainerLatestUpdates container = new ContainerLatestUpdates { Updates = updates };
            return View(container);
        }
    }
}