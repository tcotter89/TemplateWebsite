using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Shared.Models;
using TemplateWebsite.RepositoryLayer.Entities;

namespace TemplateWebsite.RepositoryLayer.Converters 
{
    public static class EntityToModelConverters 
    {
        public static ModelUpdate ConvertEntityToModel(this Update entity, WebsiteDatabaseEntities dbContext) {
            ModelUpdate model = new ModelUpdate();

            //DATABASE FIELDS
            model.UpdateID = entity.UpdateID;
            model.VersionNum = entity.VersionNum;
            model.Comment = entity.Comment;
            model.UpdateNotes = entity.UpdateNotes;
            model.CreatedDate = entity.CreatedDate;
            model.EffectiveDate = entity.EffectiveDate;

            return model;
        }

        public static ModelMediaScreenshot ConvertEntityToModel(this MediaScreenshot entity, WebsiteDatabaseEntities dbContext) {
            ModelMediaScreenshot model = new ModelMediaScreenshot();

            //DATABASE FIELDS
            model.ScreenshotID = entity.ScreenshotID;
            model.AlternateText = entity.AlternateText;
            model.URL = entity.URL;
            model.ResolutionX = entity.ResolutionX;
            model.ResolutionY = entity.ResolutionY;
            model.ThumbnailURL = entity.ThumbnailURL;
            model.ThumbnailResolutionX = entity.ThumbnailResolutionX;
            model.ThumbnailResolutionY = entity.ThumbnailResolutionY;
            model.CreatedDate = entity.CreatedDate;

            return model;
        }

        public static ModelForumsForum ConvertEntityToModel(this ForumsForum entity, WebsiteDatabaseEntities dbContext, int topicCount, int postCount, DateTime lastPostDate) {
            ModelForumsForum model = new ModelForumsForum();

            //DATABASE FIELDS
            model.ForumID = entity.ForumID;
            model.Title = entity.Title;
            model.SubTitle = entity.SubTitle;

            //METADATAFIELDS
            model.TopicCount = topicCount;
            model.PostCount = postCount;
            model.LastPostDate = lastPostDate;

            return model;
        }

        public static ModelForumsTopic ConvertEntityToModel(this ForumsTopic entity, WebsiteDatabaseEntities dbContext, int postCount, string lastPosterName, DateTime lastPostDate) {
            ModelForumsTopic model = new ModelForumsTopic();

            //DATABASE FIELDS
            model.TopicID = entity.TopicID;
            model.ForumID = entity.ForumID;
            model.Title = entity.Title;

            //METADATAFIELDS
            model.PostCount = postCount;
            model.LastPosterName = lastPosterName;
            model.LastPostDate = lastPostDate;

            return model;
        }

        public static ModelForumsPost ConvertEntityToModel(this ForumsPost entity, WebsiteDatabaseEntities dbContext, string posterName) {
            ModelForumsPost model = new ModelForumsPost();

            //DATABASE FIELDS
            model.PostID = entity.PostID;
            model.TopicID = entity.TopicID;
            model.Content = entity.Content;
            model.IsBasePost = entity.IsBasePost;
            model.UserID = entity.UserID;
            model.IP = entity.IP;
            model.PostDate = entity.PostDate;
            model.EditDate = entity.EditDate;

            //METADATAFIELDS
            model.Username = posterName;

            return model;
        }

        public static ModelWebsiteUser ConvertEntityToModel(this WebsiteUser entity, WebsiteDatabaseEntities dbContext) {
            ModelWebsiteUser model = new ModelWebsiteUser();

            //DATABASE FIELDS
            model.UserID = entity.UserID;
            model.Username = entity.Username;
            model.Email = entity.Email;
            model.HashedPassword = entity.HashedPassword;
            model.CreatedOnDate = entity.CreatedOnDate;
            model.LastLoginDate = entity.LastLoginDate;

            return model;
        }
    }
}
