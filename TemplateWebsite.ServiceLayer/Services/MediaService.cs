using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Shared.Models;
using TemplateWebsite.Shared.Repository;
using TemplateWebsite.Shared.Services;
using TemplateWebsite.RepositoryLayer.Repository;

namespace TemplateWebsite.ServiceLayer.Services 
{
    public class MediaService : IMediaService 
    {
        private readonly IMediaRepository _mediaRepository;

        public MediaService(IMediaRepository mediaRepository) {
            _mediaRepository = mediaRepository;
        }

        public List<ModelMediaScreenshot> GetAllMediaScreenshots() {
            return _mediaRepository.GetAllMediaScreenshots();
        }

        public ModelMediaScreenshot GetMediaScreenshot(int screenshotID) {
            return _mediaRepository.GetMediaScreenshot(screenshotID);
        }
    }
}
