using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Metadata used during link generation to find the associated endpoint using route name.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString(),nq}")]
	public sealed class RouteNameMetadata : IRouteNameMetadata
	{
		/// <summary>
		/// Gets the route name. Can be null.
		/// </summary>
		public string RouteName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.RouteNameMetadata" /> with the provided route name.
		/// </summary>
		/// <param name="routeName">The route name. Can be null.</param>
		public RouteNameMetadata(string routeName)
		{
			throw null;
		}

		internal string DebuggerToString()
		{
			throw null;
		}
	}
}
