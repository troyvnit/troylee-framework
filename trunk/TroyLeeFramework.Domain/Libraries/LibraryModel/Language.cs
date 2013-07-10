using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;

namespace TroyLeeFramework.Domain.Libraries.LibraryModel
{
    public class Language
    {
        public string Url { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public RouteValueDictionary RouteValues { get; set; }
        public bool IsSelected { get; set; }
        public MvcHtmlString HtmlSafeUrl
        {
            get
            {
                return MvcHtmlString.Create(Url);
            }
        }
    }
}
