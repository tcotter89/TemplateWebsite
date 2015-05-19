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
    public class ForumsForumRepository : BaseRepository, IForumsForumRepository 
    {
        public List<ModelForumsForum> GetAllForums() {
            var entities = dbContext.ForumsForums;
            List<ModelForumsForum> models = new List<ModelForumsForum>();

            //only convert and find additional data if some forums were found
            if (entities.Count() > 0) {
                foreach (var entity in entities) {
                    models.Add(GetExtraForumData(entity));
                };
            }
            return models;
        }
        public ModelForumsForum GetForum(int forumID) {
            var entity = dbContext.ForumsForums.SingleOrDefault(f => f.ForumID == forumID);
            ModelForumsForum model;

            //only convert and find additional data if the forum was found
            if (entity != null) {
                model = GetExtraForumData(entity);
            } else {
                model = new ModelForumsForum();
            }
            return model;
        }
        public ModelForumsForum GetForum(string title) {
            var entity = dbContext.ForumsForums.SingleOrDefault(f => f.Title == title);
            ModelForumsForum model;

            //only convert and find additional data if the forum was found
            if (entity != null) {
                model = GetExtraForumData(entity);
            } else {
                model = new ModelForumsForum();
            }
            return model;
        }
        internal ModelForumsForum GetExtraForumData(ForumsForum entity) {
            int topicCount = dbContext.ForumsTopics.Where(t => t.ForumID == entity.ForumID).Count();
            int postCount = dbContext.ForumsPosts
                                .Join(dbContext.ForumsTopics,
                                    p => p.TopicID,
                                    t => t.TopicID,
                                    (p, t) => new { ForumsPost = p, ForumsTopic = t })
                                .Where(t => t.ForumsTopic.ForumID == entity.ForumID)
                                .Count();
            DateTime lastPostDate = dbContext.ForumsPosts
                                        .Join(dbContext.ForumsTopics,
                                            p => p.TopicID,
                                            t => t.TopicID,
                                            (p, t) => new { ForumsPost = p, ForumsTopic = t })
                                        .Where(t => t.ForumsTopic.ForumID == entity.ForumID)
                                        .OrderBy(p => p.ForumsPost.PostDate)
                                        .Select(p => p.ForumsPost.PostDate)
                                        .FirstOrDefault();
            return entity.ConvertEntityToModel(dbContext, topicCount, postCount, lastPostDate);
        }
    }
}
