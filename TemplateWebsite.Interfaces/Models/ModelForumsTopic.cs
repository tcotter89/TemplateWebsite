using System;
using System.Collections.Generic;

namespace TemplateWebsite.Shared.Models 
{
    public class ModelForumsTopic
    {
        //DATABASE FIELDS
        public int TopicID { get; set; }
        public int ForumID { get; set; }
        private string _title;
        public string Title {
            get {
                return _title;
            }
            set {
                _title = value;
                _urlName = value.Replace(' ', '-');
            }
        }

        //METADATA FIELDS
        private string _urlName;
        public string UrlName {
            get {
                return _urlName;
            }
        }
        public int PostCount { get; set; }
        public string LastPosterName { get; set; }
        public DateTime LastPostDate { get; set; }
    }
}