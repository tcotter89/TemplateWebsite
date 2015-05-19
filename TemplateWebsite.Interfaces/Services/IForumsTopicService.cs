using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Shared.Models;

namespace TemplateWebsite.Shared.Services 
{
    public interface IForumsTopicService
    {
        List<ModelForumsTopic> GetAllTopicsOfForum(int forumID);
        ModelForumsTopic GetTopic(int topicID);
        ModelForumsTopic GetTopic(string urlName);
        int AddTopic(ModelForumsTopic topic);
    }
}
