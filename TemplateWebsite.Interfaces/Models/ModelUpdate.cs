using System;
using System.Collections.Generic;

namespace TemplateWebsite.Shared.Models 
{
    public class ModelUpdate
    {
        public int UpdateID { get; set; }
        public string VersionNum { get; set; }
        public string Comment { get; set; }
        public string UpdateNotes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}