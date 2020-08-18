using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Specifies an endpoint name in <see cref="P:Microsoft.AspNetCore.Http.Endpoint.Metadata" />.
	/// </summary>
	/// <remarks>
	/// Endpoint names must be unique within an application, and can be used to unambiguously
	/// identify a desired endpoint for URI generation using <see cref="T:Microsoft.AspNetCore.Routing.LinkGenerator" />.
	/// </remarks>
	public class EndpointNameMetadata : IEndpointNameMetadata
	{
		/// <summary>
		/// Gets the endpoint name.
		/// </summary>
		public string EndpointName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.EndpointNameMetadata" /> with the provided endpoint name.
		/// </summary>
		/// <param name="endpointName">The endpoint name.</param>
		public EndpointNameMetadata(string endpointName)
		{
			throw null;
		}
	}
}
