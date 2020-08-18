using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Patterns;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Represents an <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> that can be used in URL matching or URL generation.
	/// </summary>
	public sealed class RouteEndpoint : Endpoint
	{
		/// <summary>
		/// Gets the order value of endpoint.
		/// </summary>
		/// <remarks>
		/// The order value provides absolute control over the priority
		/// of an endpoint. Endpoints with a lower numeric value of order have higher priority.
		/// </remarks>
		public int Order
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="P:Microsoft.AspNetCore.Routing.RouteEndpoint.RoutePattern" /> associated with the endpoint.
		/// </summary>
		public RoutePattern RoutePattern
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> class.
		/// </summary>
		/// <param name="requestDelegate">The delegate used to process requests for the endpoint.</param>
		/// <param name="routePattern">The <see cref="P:Microsoft.AspNetCore.Routing.RouteEndpoint.RoutePattern" /> to use in URL matching.</param>
		/// <param name="order">The order assigned to the endpoint.</param>
		/// <param name="metadata">
		/// The <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection" /> or metadata associated with the endpoint.
		/// </param>
		/// <param name="displayName">The informational display name of the endpoint.</param>
		public RouteEndpoint(RequestDelegate requestDelegate, RoutePattern routePattern, int order, EndpointMetadataCollection? metadata, string? displayName)
		{
			throw null;
		}
	}
}
