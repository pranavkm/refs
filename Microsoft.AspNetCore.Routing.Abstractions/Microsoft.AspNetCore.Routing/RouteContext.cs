using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// A context object for <see cref="M:Microsoft.AspNetCore.Routing.IRouter.RouteAsync(Microsoft.AspNetCore.Routing.RouteContext)" />.
	/// </summary>
	public class RouteContext
	{
		/// <summary>
		/// Gets or sets the handler for the request. An <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> should set <see cref="P:Microsoft.AspNetCore.Routing.RouteContext.Handler" />
		/// when it matches.
		/// </summary>
		public RequestDelegate? Handler
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.
		/// </summary>
		public HttpContext HttpContext
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> associated with the current context.
		/// </summary>
		public RouteData RouteData
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

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.RouteContext" /> for the provided <paramref name="httpContext" />.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		public RouteContext(HttpContext httpContext)
		{
			throw null;
		}
	}
}
