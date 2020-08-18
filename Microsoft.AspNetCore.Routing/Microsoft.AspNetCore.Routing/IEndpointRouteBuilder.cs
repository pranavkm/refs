using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Defines a contract for a route builder in an application. A route builder specifies the routes for
	/// an application.
	/// </summary>
	public interface IEndpointRouteBuilder
	{
		/// <summary>
		/// Gets the sets the <see cref="T:System.IServiceProvider" /> used to resolve services for routes.
		/// </summary>
		IServiceProvider ServiceProvider
		{
			get;
		}

		/// <summary>
		/// Gets the endpoint data sources configured in the builder.
		/// </summary>
		ICollection<EndpointDataSource> DataSources
		{
			get;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
		/// </summary>
		/// <returns>The new <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		IApplicationBuilder CreateApplicationBuilder();
	}
}
