using System.Collections.Generic;
using System.Web.Mvc;

namespace MemcachedSessionStateDemo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var history = (List<string>)Session["ServerHistory"] ?? new List<string>();
			history.Add(string.Format("{0}", System.Environment.MachineName));
			Session["ServerHistory"] = history;
			return View(history);
		}
	}
}
