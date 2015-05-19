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
    public class UpdatesService : IUpdatesService 
    {
        private readonly IUpdatesRepository _updatesRepository;

        public UpdatesService(IUpdatesRepository updatesRepository) {
            _updatesRepository = updatesRepository;
        }

        public List<ModelUpdate> GetAllUpdates() {
            return _updatesRepository.GetAllUpdates();
        }

        public ModelUpdate GetUpdate(int updateID) {
            return _updatesRepository.GetUpdate(updateID);
        }
    }
}
