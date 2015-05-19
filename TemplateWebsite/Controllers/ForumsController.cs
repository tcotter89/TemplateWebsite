using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateWebsite.App_Start;
using TemplateWebsite.Shared.Models;
using TemplateWebsite.Shared.Services;
using TemplateWebsite.Shared.Utilities;

namespace TemplateWebsite.Controllers
{
    public class ForumsController : Controller
    {
        private readonly IForumsForumService _forumsForumService;
        private readonly IForumsTopicService _forumsTopicService;
        private readonly IForumsPostService _forumsPostService;

        public ForumsController() {
            var dependencyInjection = NinjectWebCommon.bootstrapper.Kernel;
            _forumsForumService = (IForumsForumService)dependencyInjection.GetService(typeof(IForumsForumService));
            _forumsTopicService = (IForumsTopicService)dependencyInjection.GetService(typeof(IForumsTopicService));
            _forumsPostService = (IForumsPostService)dependencyInjection.GetService(typeof(IForumsPostService));
        }

        public ForumsController(IForumsForumService forumsForumService, IForumsTopicService forumsTopicService, IForumsPostService forumsPostService) {
            _forumsForumService = forumsForumService;
            _forumsTopicService = forumsTopicService;
            _forumsPostService = forumsPostService;
        }

        public ActionResult Index() {
            List<ModelForumsForum> forums = _forumsForumService.GetAllForums();
            ContainerForumsIndex container = new ContainerForumsIndex { Forums = forums };
            return View(container);
        }

        public ActionResult Forum(string urlName) {
            ModelForumsForum forum = _forumsForumService.GetForum(urlName);
            List<ModelForumsTopic> topics = _forumsTopicService.GetAllTopicsOfForum(forum.ForumID);
            ContainerForumsForum container = new ContainerForumsForum() { Forum = forum, Topics = topics };
            return View(container);
        }

        public ActionResult Topic(string urlName) {
            ModelForumsTopic topic = _forumsTopicService.GetTopic(urlName);
            string forumUrlName = _forumsForumService.GetForum(topic.ForumID).UrlName;
            List<ModelForumsPost> posts = _forumsPostService.GetAllPostsOfTopic(topic.TopicID);
            ContainerForumsTopic container = new ContainerForumsTopic() { ForumUrlName = forumUrlName, Topic = topic, Posts = posts };
            return View(container);
        }

        public ActionResult NewTopic(int forumID) {
            ModelForumsForum forum = _forumsForumService.GetForum(forumID);
            ContainerNewTopic container = new ContainerNewTopic() { Forum = forum };
            return View(container);
        }

        //[HttpPost]
        public ActionResult SubmitNewTopic(int forumID, string forumUrlName, ContainerNewTopic container) {
            DateTime currentDate = DateTime.Now;

            ModelForumsTopic topic = new ModelForumsTopic() { 
                ForumID = forumID, 
                Title = container.Title 
            };
            int topicID = _forumsTopicService.AddTopic(topic);

            ModelForumsPost basePost = new ModelForumsPost() {
                TopicID = topicID,
                IsBasePost = true,
                Content = container.Content,
                IP = Utilities.GetLocalIPAddress(),
                PostDate = currentDate,
                EditDate = currentDate,
                UserID = 1  //TODO: hook this up correctly
            };
            int postID = _forumsPostService.AddPost(basePost);

            return RedirectToAction("Forum", new { urlName = forumUrlName });
        }

        public ActionResult SubmitNewPost(int topicID, string topicUrlName, ContainerForumsTopic container) {
            DateTime currentDate = DateTime.Now;

            ModelForumsPost reply = new ModelForumsPost() {
                TopicID = topicID,
                IsBasePost = false,
                Content = container.Content,
                IP = Utilities.GetLocalIPAddress(),
                PostDate = currentDate,
                EditDate = currentDate,
                UserID = 1  //TODO: hook this up correctly
            };
            int postID = _forumsPostService.AddPost(reply);

            return RedirectToAction("Topic", new { urlName = topicUrlName });
        }
    }
}