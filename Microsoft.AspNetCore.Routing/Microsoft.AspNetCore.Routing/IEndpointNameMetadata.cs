namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Defines a contract use to specify an endpoint name in <see cref="P:Microsoft.AspNetCore.Http.Endpoint.Metadata" />.
	/// </summary>
	/// <remarks>
	/// Endpoint names must be unique within an application, and can be used to unambiguously
	/// identify a desired endpoint for URI generation using <see cref="T:Microsoft.AspNetCore.Routing.LinkGenerator" />.
	/// </remarks>
	public interface IEndpointNameMetadata
	{
		/// <summary>
		/// Gets the endpoint name.
		/// </summary>
		string EndpointName
		{
			get;
		}
	}
}
