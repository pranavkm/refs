using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing.Matching
{
	public abstract class PolicyJumpTable
	{
		public abstract int GetDestination(HttpContext httpContext);

		internal virtual string DebuggerToString()
		{
			throw null;
		}

		protected PolicyJumpTable()
		{
			throw null;
		}
	}
}
