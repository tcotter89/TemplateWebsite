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
    public class ForumsForumService : IForumsForumService 
    {
        private readonly IForumsForumRepository _forumsForumRepository;

        public ForumsForumService(IForumsForumRepository forumsForumRepository) {
            _forumsForumRepository = forumsForumRepository;
        }

        public List<ModelForumsForum> GetAllForums() {
            return _forumsForumRepository.GetAllForums();
        }

        public ModelForumsForum GetForum(int forumID) {
            return _forumsForumRepository.GetForum(forumID);
        }

        public ModelForumsForum GetForum(string urlName) {
            if (urlName != null) {
                string title = urlName.Replace('-', ' ');
                return _forumsForumRepository.GetForum(title);
            } else {
                return new ModelForumsForum();
            }
        }
    }
}
