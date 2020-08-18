using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Defines a class that provides the mechanisms to configure an application's request pipeline.
	/// </summary>
	public interface IApplicationBuilder
	{
		/// <summary>
		/// Gets or sets the <see cref="T:System.IServiceProvider" /> that provides access to the application's service container.
		/// </summary>
		IServiceProvider ApplicationServices
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the set of HTTP features the application's server provides.
		/// </summary>
		IFeatureCollection ServerFeatures
		{
			get;
		}

		/// <summary>
		/// Gets a key/value collection that can be used to share data between middleware.
		/// </summary>
		IDictionary<string, object?> Properties
		{
			get;
		}

		/// <summary>
		/// Adds a middleware delegate to the application's request pipeline.
		/// </summary>
		/// <param name="middleware">The middleware delegate.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> that shares the <see cref="P:Microsoft.AspNetCore.Builder.IApplicationBuilder.Properties" /> of this
		/// <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
		/// </summary>
		/// <returns>The new <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</returns>
		IApplicationBuilder New();

		/// <summary>
		/// Builds the delegate used by this application to process HTTP requests.
		/// </summary>
		/// <returns>The request handling delegate.</returns>
		RequestDelegate Build();
	}
}
