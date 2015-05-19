using System;
using System.Collections.Generic;

namespace TemplateWebsite.Shared.Models 
{
    public class ModelMediaScreenshot 
    {
        public int ScreenshotID { get; set; }
        public string AlternateText { get; set; }
        public string URL { get; set; }
        public int ResolutionX { get; set; }
        public int ResolutionY { get; set; }
        public string ThumbnailURL { get; set; }
        public Nullable<int> ThumbnailResolutionX { get; set; }
        public Nullable<int> ThumbnailResolutionY { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
    }
}