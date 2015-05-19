using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Shared.Models;

namespace TemplateWebsite.Shared.Services 
{
    public interface IMediaService
    {
        List<ModelMediaScreenshot> GetAllMediaScreenshots();
        ModelMediaScreenshot GetMediaScreenshot(int screenshotID);
    }
}
