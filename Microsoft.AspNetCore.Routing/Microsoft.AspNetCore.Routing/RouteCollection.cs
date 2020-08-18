using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
	public class RouteCollection : IRouteCollection, IRouter
	{
		public IRouter this[int index]
		{
			get
			{
				throw null;
			}
		}

		public int Count
		{
			get
			{
				throw null;
			}
		}

		public void Add(IRouter router)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CRouteAsync_003Ed__10))]
		[DebuggerStepThrough]
		public virtual Task RouteAsync(RouteContext context)
		{
			throw null;
		}

		public virtual VirtualPathData? GetVirtualPath(VirtualPathContext context)
		{
			throw null;
		}

		public RouteCollection()
		{
			throw null;
		}
	}
}
