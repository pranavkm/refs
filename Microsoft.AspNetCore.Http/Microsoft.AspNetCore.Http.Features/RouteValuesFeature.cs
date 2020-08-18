using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// A feature for routing values. Use <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Features" />
	/// to access the values associated with the current request.
	/// </summary>
	public class RouteValuesFeature : IRouteValuesFeature
	{
		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> associated with the currrent
		/// request.
		/// </summary>
		public RouteValueDictionary RouteValues
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public RouteValuesFeature()
		{
			throw null;
		}
	}
}
