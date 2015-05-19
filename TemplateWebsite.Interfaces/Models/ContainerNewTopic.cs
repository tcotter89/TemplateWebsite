using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TemplateWebsite.Shared.Models 
{
    public class ContainerNewTopic 
    {
        public ModelForumsForum Forum { get; set; }

        //FORM-FILLED IN FIELDS
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}
