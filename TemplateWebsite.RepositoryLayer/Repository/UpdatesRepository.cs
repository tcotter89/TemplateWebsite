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
    public class UpdatesRepository : BaseRepository, IUpdatesRepository 
    {
        public List<ModelUpdate> GetAllUpdates() {
            var entities = dbContext.Updates;
            List<ModelUpdate> models = new List<ModelUpdate>();

            foreach (var entity in entities) {
                models.Add(entity.ConvertEntityToModel(dbContext));
            };
            return models;
        }
        public ModelUpdate GetUpdate(int updateID) {
            var entity = dbContext.Updates.SingleOrDefault(u => u.UpdateID == updateID);
            var model = entity.ConvertEntityToModel(dbContext);
            return model;
        }
    }
}
