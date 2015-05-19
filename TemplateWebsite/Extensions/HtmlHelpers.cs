using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TemplateWebsite.Extensions {
    public static class HtmlHelpers {
        public static MvcHtmlString MenuItem(this HtmlHelper htmlHelper, string action, string controller, string text) {
            //var menu = new TagBuilder("li");
            //menu.Attributes.Add("role", "presentation");

            //var currentAction = (string)htmlHelper.ViewContext.RouteData.Values["action"];

            //if (string.Equals(currentAction, action, StringComparison.CurrentCultureIgnoreCase)) {
            //    menu.AddCssClass("active");
            //}
            //var url = new UrlHelper(HttpContext.Current.Request.RequestContext);
            //menu.SetInnerText(String.Format("<a href=\"{0}\">{1}</a>", url.Action(action, controller), text));
            //return MvcHtmlString.Create(menu.ToString());

            var currentControllerName = (string)htmlHelper.ViewContext.RouteData.Values["controller"];
            var currentActionName = (string)htmlHelper.ViewContext.RouteData.Values["action"];
            var sb = new StringBuilder();
            sb.AppendFormat("<li {0} {1}", "role='presentation'", (currentControllerName.Equals(controller, StringComparison.CurrentCultureIgnoreCase) &&
                                                currentActionName.Equals(action, StringComparison.CurrentCultureIgnoreCase)
                                                    ? "class=\"active\">" : ">"));
            var url = new UrlHelper(HttpContext.Current.Request.RequestContext);
            sb.AppendFormat("<a href=\"{0}\">{1}</a>", url.Action(action, controller), text);
            sb.Append("</li>");
            return new MvcHtmlString(sb.ToString());
        }
    }
}