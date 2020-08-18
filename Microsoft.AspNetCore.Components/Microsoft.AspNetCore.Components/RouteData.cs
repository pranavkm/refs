using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Describes information determined during routing that specifies
	/// the page to be displayed.
	/// </summary>
	public sealed class RouteData
	{
		/// <summary>
		/// Gets the type of the page matching the route.
		/// </summary>
		public Type PageType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets route parameter values extracted from the matched route.
		/// </summary>
		public IReadOnlyDictionary<string, object> RouteValues
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.RouteData" />.
		/// </summary>
		/// <param name="pageType">The type of the page matching the route, which must implement <see cref="T:Microsoft.AspNetCore.Components.IComponent" />.</param>
		/// <param name="routeValues">The route parameter values extracted from the matched route.</param>
		public RouteData(Type pageType, IReadOnlyDictionary<string, object> routeValues)
		{
			throw null;
		}
	}
}
