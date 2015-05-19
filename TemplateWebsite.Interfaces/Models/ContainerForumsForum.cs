using System.Collections.Generic;

namespace TemplateWebsite.Shared.Models 
{
    public class ContainerForumsForum
    {
        public ModelForumsForum Forum { get; set; }
        public List<ModelForumsTopic> Topics { get; set; }
    }
}
