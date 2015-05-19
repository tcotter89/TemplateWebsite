using System;
using System.Collections.Generic;

namespace TemplateWebsite.Shared.Models 
{
    public class ModelWebsiteUser
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public System.DateTime CreatedOnDate { get; set; }
        public System.DateTime LastLoginDate { get; set; }
    }
}