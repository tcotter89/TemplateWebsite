using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TemplateWebsite.Shared.Models 
{
    public class ContainerForumsTopic
    {
        public string ForumUrlName { get; set; }
        public ModelForumsTopic Topic { get; set; }
        public List<ModelForumsPost> Posts { get; set; }

        //FORM-FILLED IN FIELDS
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}
