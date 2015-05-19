using System;
using System.Collections.Generic;

namespace TemplateWebsite.Shared.Models 
{
    public class ModelForumsForum
    {
        //DATABASE FIELDS
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
        public string SubTitle { get; set; }

        //METADATA FIELDS
        private string _urlName;
        public string UrlName {
            get {
                return _urlName;
            }
        }
        public int TopicCount { get; set; }
        public int PostCount { get; set; }
        public DateTime LastPostDate { get; set; }
    }
}