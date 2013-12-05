using System.Security.Permissions;
using System.Web.Mvc;
using Vanilla.Lib.Security;

namespace Vanilla.Controllers
{
	[Authorize]
	public class GuestController : Controller
	{
		[PrincipalPermission(SecurityAction.Demand, Role = Roles.Guest)]
		public ActionResult Index()
		{
			return View();
		}
	}
}