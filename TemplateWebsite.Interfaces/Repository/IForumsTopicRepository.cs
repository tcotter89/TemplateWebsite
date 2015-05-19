using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Shared.Models;

namespace TemplateWebsite.Shared.Repository 
{
    public interface IForumsTopicRepository 
    {
        List<ModelForumsTopic> GetAllTopicsOfForum(int forumID);
        ModelForumsTopic GetTopic(int topicID);
        ModelForumsTopic GetTopic(string title);
        int AddTopic(ModelForumsTopic topic);
    }
}
