using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Interfaces.Services;
using TemplateWebsite.Models;
using TemplateWebsite.RepositoryLayer.Repository;

namespace TemplateWebsite.ServicesLayer.Services {
    public class UpdatesService : IUpdatesService {
        public Updates GetUpdate(int updateID) {
            UpdatesRepository _updatesRepository = new UpdatesRepository();
            return _updatesRepository.GetUpdate(updateID);
        }
    }
}
