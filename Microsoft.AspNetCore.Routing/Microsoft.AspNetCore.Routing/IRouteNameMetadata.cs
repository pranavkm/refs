namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents metadata used during link generation to find
	/// the associated endpoint using route name.
	/// </summary>
	public interface IRouteNameMetadata
	{
		/// <summary>
		/// Gets the route name. Can be null.
		/// </summary>
		string RouteName
		{
			get;
		}
	}
}
