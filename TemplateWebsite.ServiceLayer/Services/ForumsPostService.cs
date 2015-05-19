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
    public class ForumsPostService : IForumsPostService 
    {
        private readonly IForumsPostRepository _forumsPostRepository;

        public ForumsPostService(IForumsPostRepository forumsPostRepository) {
            _forumsPostRepository = forumsPostRepository;
        }

        public List<ModelForumsPost> GetAllPostsOfTopic(int topicID) {
            return _forumsPostRepository.GetAllPostsOfTopic(topicID);
        }

        public ModelForumsPost GetPost(int postID) {
            return _forumsPostRepository.GetPost(postID);
        }
        public int AddPost(ModelForumsPost post) {
            return _forumsPostRepository.AddPost(post);
        }
    }
}
