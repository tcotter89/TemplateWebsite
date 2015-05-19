using System;
using System.Collections.Generic;

namespace TemplateWebsite.Shared.Models 
{
    public class ModelForumsPost
    {
        //DATABASE FIELDS
        public int PostID { get; set; }
        public int TopicID { get; set; }
        public string Content { get; set; }
        public bool IsBasePost { get; set; }
        public int UserID { get; set; }
        public string IP { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime EditDate { get; set; }

        //METADATA FIELDS
        public string Username { get; set; }

    }
}