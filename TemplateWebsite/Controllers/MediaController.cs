using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateWebsite.App_Start;
using TemplateWebsite.Shared.Models;
using TemplateWebsite.Shared.Services;

namespace TemplateWebsite.Controllers
{
    public class MediaController : Controller
    {
        private readonly IMediaService _mediaService;

        public MediaController() {
            var container = NinjectWebCommon.bootstrapper.Kernel;
            _mediaService = (IMediaService)container.GetService(typeof(IMediaService));
        }

        public MediaController(IMediaService mediaService) {
            _mediaService = mediaService;
        }

        public ActionResult Index() {
            List<ModelMediaScreenshot> screenshots = _mediaService.GetAllMediaScreenshots();
            ContainerMedia container = new ContainerMedia { Screenshots = screenshots };
            return View(container);
        }
    }
}