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
    public class ForumsTopicService : IForumsTopicService 
    {
        private readonly IForumsTopicRepository _forumsTopicRepository;

        public ForumsTopicService(IForumsTopicRepository forumsTopicRepository) {
            _forumsTopicRepository = forumsTopicRepository;
        }

        public List<ModelForumsTopic> GetAllTopicsOfForum(int forumID) {
            return _forumsTopicRepository.GetAllTopicsOfForum(forumID);
        }

        public ModelForumsTopic GetTopic(int topicID) {
            return _forumsTopicRepository.GetTopic(topicID);
        }

        public ModelForumsTopic GetTopic(string urlName) {
            if (urlName != null) {
                string title = urlName.Replace('-', ' ');
                return _forumsTopicRepository.GetTopic(title);
            } else {
                return new ModelForumsTopic();
            }
        }
        public int AddTopic(ModelForumsTopic topic) {
            return _forumsTopicRepository.AddTopic(topic);
        }
    }
}
