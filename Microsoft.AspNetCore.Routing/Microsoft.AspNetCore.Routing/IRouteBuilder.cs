using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Defines a contract for a route builder in an application. A route builder specifies the routes for
	/// an application.
	/// </summary>
	public interface IRouteBuilder
	{
		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
		/// </summary>
		IApplicationBuilder ApplicationBuilder
		{
			get;
		}

		/// <summary>
		/// Gets or sets the default <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> that is used as a handler if an <see cref="T:Microsoft.AspNetCore.Routing.IRouter" />
		/// is added to the list of routes but does not specify its own.
		/// </summary>
		IRouter? DefaultHandler
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get;
			[System.Runtime.CompilerServices.NullableContext(2)]
			set;
		}

		/// <summary>
		/// Gets the sets the <see cref="T:System.IServiceProvider" /> used to resolve services for routes.
		/// </summary>
		IServiceProvider ServiceProvider
		{
			get;
		}

		/// <summary>
		/// Gets the routes configured in the builder.
		/// </summary>
		IList<IRouter> Routes
		{
			get;
		}

		/// <summary>
		/// Builds an <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> that routes the routes specified in the <see cref="P:Microsoft.AspNetCore.Routing.IRouteBuilder.Routes" /> property.
		/// </summary>
		IRouter Build();
	}
}
