using System.IdentityModel.Services;
using System.Security.Permissions;
using System.Web.Mvc;
using Vanilla.Lib.Security;

namespace Vanilla.Controllers
{
	[ClaimsPrincipalPermission(SecurityAction.Demand, Operation = Operations.View, Resource = Resources.Admin.Index)]
	public class AdminController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}