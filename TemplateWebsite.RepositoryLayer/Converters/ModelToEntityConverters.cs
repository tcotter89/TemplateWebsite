using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.Shared.Models;
using TemplateWebsite.RepositoryLayer.Entities;

namespace TemplateWebsite.RepositoryLayer.Converters 
{
    public static class ModelToEntityConverters 
    {
        public static Update ConvertModelToEntity(this ModelUpdate model, WebsiteDatabaseEntities dbContext) {
            Update entity = new Update();

            entity.UpdateID = model.UpdateID;
            entity.VersionNum = model.VersionNum;
            entity.Comment = model.Comment;
            entity.UpdateNotes = model.UpdateNotes;
            entity.CreatedDate = model.CreatedDate;
            entity.EffectiveDate = model.EffectiveDate;

            return entity;
        }

        public static MediaScreenshot ConvertModelToEntity(this ModelMediaScreenshot model, WebsiteDatabaseEntities dbContext) {
            MediaScreenshot entity = new MediaScreenshot();

            entity.ScreenshotID = model.ScreenshotID;
            entity.AlternateText = model.AlternateText;
            entity.URL = model.URL;
            entity.ResolutionX = model.ResolutionX;
            entity.ResolutionY = model.ResolutionY;
            entity.ThumbnailURL = model.ThumbnailURL;
            entity.ThumbnailResolutionX = model.ThumbnailResolutionX;
            entity.ThumbnailResolutionY = model.ThumbnailResolutionY;
            entity.CreatedDate = model.CreatedDate;

            return entity;
        }

        public static ForumsForum ConvertModelToEntity(this ModelForumsForum model, WebsiteDatabaseEntities dbContext) {
            ForumsForum entity = new ForumsForum();

            entity.ForumID = model.ForumID;
            entity.Title = model.Title;
            entity.SubTitle = model.SubTitle;

            return entity;
        }

        public static ForumsTopic ConvertModelToEntity(this ModelForumsTopic model, WebsiteDatabaseEntities dbContext) {
            ForumsTopic entity = new ForumsTopic();

            entity.TopicID = model.TopicID;
            entity.ForumID = model.ForumID;
            entity.Title = model.Title;

            return entity;
        }

        public static ForumsPost ConvertModelToEntity(this ModelForumsPost model, WebsiteDatabaseEntities dbContext) {
            ForumsPost entity = new ForumsPost();

            entity.PostID = model.PostID;
            entity.TopicID = model.TopicID;
            entity.Content = model.Content;
            entity.IsBasePost = model.IsBasePost;
            entity.UserID = model.UserID;
            entity.IP = model.IP;
            entity.PostDate = model.PostDate;
            entity.EditDate = model.EditDate;

            return entity;
        }

        public static WebsiteUser ConvertModelToEntity(this ModelWebsiteUser model, WebsiteDatabaseEntities dbContext) {
            WebsiteUser entity = new WebsiteUser();

            entity.UserID = model.UserID;
            entity.Username = model.Username;
            entity.Email = model.Email;
            entity.HashedPassword = model.HashedPassword;
            entity.CreatedOnDate = model.CreatedOnDate;
            entity.LastLoginDate = model.LastLoginDate;

            return entity;
        }
    }
}
