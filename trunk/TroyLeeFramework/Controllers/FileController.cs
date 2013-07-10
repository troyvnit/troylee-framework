using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace TroyLeeFramework.Controllers
{
    using System.Collections.Generic;

    public class FileController : Controller
    {
        //
        // GET: /File/

        public ActionResult Index(string folder)
        {
            var result = "";
            var directories = Directory.GetDirectories(Server.MapPath("~/Images/" + folder), "*.*", SearchOption.TopDirectoryOnly).Select(directory => new DirectoryInfo(directory)).ToList();
            result += ShowTree(directories);
            ViewBag.Directories = result;
            return View("~/Views/Admin/File/Index.cshtml");
        }

        public string ShowTree(List<DirectoryInfo> infos)
        {
            var result = "<ul>";
            foreach (var info in infos)
            {
                result += "<li data-expanded=\"true\"><span class=\"k-sprite folder\"></span>" + info.Name;
                var directories = Directory.GetDirectories(info.FullName, "*.*", SearchOption.TopDirectoryOnly).Select(directory => new DirectoryInfo(directory)).Where(a => a.Parent != null && a.Parent.Name == info.Name).ToList();
                if (directories.Any())
                {
                    result += ShowTree(directories);
                }
                result += "</li>";
            }
            result += "</ul>";
            return result;
        }

        public ActionResult GetDirectories(string folder)
        {
            if (!Directory.Exists(Server.MapPath("~/" + folder)))
            {
                return Json(new {success = false});
            }
            var files = Directory.GetFiles(Server.MapPath("~/" + folder), "*.*", SearchOption.TopDirectoryOnly).Select(Path.GetFileName).ToList();
            return Json(new {files, success = false }, JsonRequestBehavior.AllowGet);
        }
    }
}
