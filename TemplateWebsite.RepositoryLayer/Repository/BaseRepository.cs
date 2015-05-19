using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateWebsite.RepositoryLayer.Entities;

namespace TemplateWebsite.RepositoryLayer.Repository 
{
    public class BaseRepository 
    {
        internal WebsiteDatabaseEntities dbContext { get; set; }
        internal BaseRepository() {
            dbContext = new WebsiteDatabaseEntities();
        }
    }
}
