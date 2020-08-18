using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
	internal class NullRouter : IRouter
	{
		public static readonly NullRouter Instance;

		public VirtualPathData? GetVirtualPath(VirtualPathContext context)
		{
			throw null;
		}

		public Task RouteAsync(RouteContext context)
		{
			throw null;
		}
	}
}
