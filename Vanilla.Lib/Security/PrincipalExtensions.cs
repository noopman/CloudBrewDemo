using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;

namespace Vanilla.Lib.Security
{
	public static class PrincipalExtensions
	{
		public static bool IsAdmin(this IPrincipal principal)
		{
			var claimsPrincipal = principal as ClaimsPrincipal;
			return claimsPrincipal != null && claimsPrincipal.FindFirst(c => c.Type == ClaimTypes.Role && c.Value == Roles.Admin) != null;
		}

		public static IEnumerable<Claim> GetClaims(this IPrincipal principal)
		{
			var claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;
			return claimsPrincipal != null ? claimsPrincipal.Claims : Enumerable.Empty<Claim>();
		}
	}
}