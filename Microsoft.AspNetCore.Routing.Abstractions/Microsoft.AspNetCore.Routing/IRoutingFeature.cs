namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// A feature interface for routing functionality.
	/// </summary>
	public interface IRoutingFeature
	{
		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> associated with the current request.
		/// </summary>
		RouteData? RouteData
		{
			get;
			set;
		}
	}
}
