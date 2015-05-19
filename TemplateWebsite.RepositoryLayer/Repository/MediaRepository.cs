using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Shared.Repository;
using TemplateWebsite.Shared.Models;
using TemplateWebsite.RepositoryLayer.Entities;
using TemplateWebsite.RepositoryLayer.Converters;

namespace TemplateWebsite.RepositoryLayer.Repository 
{
    public class MediaRepository : BaseRepository, IMediaRepository 
    {
        public List<ModelMediaScreenshot> GetAllMediaScreenshots() {
            var entities = dbContext.MediaScreenshots;
            List<ModelMediaScreenshot> models = new List<ModelMediaScreenshot>();

            foreach (var entity in entities) {
                models.Add(entity.ConvertEntityToModel(dbContext));
            };
            return models;
        }
        public ModelMediaScreenshot GetMediaScreenshot(int screenshotID) {
            var entity = dbContext.MediaScreenshots.SingleOrDefault(s => s.ScreenshotID == screenshotID);
            var model = entity.ConvertEntityToModel(dbContext);
            return model;
        }
    }
}
