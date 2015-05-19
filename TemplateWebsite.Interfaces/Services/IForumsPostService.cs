using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Shared.Models;

namespace TemplateWebsite.Shared.Services 
{
    public interface IForumsPostService
    {
        List<ModelForumsPost> GetAllPostsOfTopic(int topicID);
        ModelForumsPost GetPost(int postID);
        int AddPost(ModelForumsPost model);
    }
}
