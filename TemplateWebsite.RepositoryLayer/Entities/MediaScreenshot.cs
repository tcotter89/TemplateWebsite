//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemplateWebsite.RepositoryLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MediaScreenshot
    {
        public int ScreenshotID { get; set; }
        public string AlternateText { get; set; }
        public string URL { get; set; }
        public int ResolutionX { get; set; }
        public int ResolutionY { get; set; }
        public string ThumbnailURL { get; set; }
        public Nullable<int> ThumbnailResolutionX { get; set; }
        public Nullable<int> ThumbnailResolutionY { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}