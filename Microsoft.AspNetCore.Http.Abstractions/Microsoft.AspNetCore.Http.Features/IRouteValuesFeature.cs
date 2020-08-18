using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// A feature interface for routing values. Use <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Features" />
	/// to access the values associated with the current request.
	/// </summary>
	public interface IRouteValuesFeature
	{
		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> associated with the currrent
		/// request.
		/// </summary>
		RouteValueDictionary RouteValues
		{
			get;
			set;
		}
	}
}
