using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// A context for virtual path generation operations.
	/// </summary>
	public class VirtualPathContext
	{
		/// <summary>
		/// Gets the set of route values associated with the current request.
		/// </summary>
		public RouteValueDictionary AmbientValues
		{
			[CompilerGenerated]
			get
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
		/// Gets the name of the route to use for virtual path generation.
		/// </summary>
		public string? RouteName
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the set of new values provided for virtual path generation.
		/// </summary>
		public RouteValueDictionary Values
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.VirtualPathContext" />.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <param name="ambientValues">The set of route values associated with the current request.</param>
		/// <param name="values">The set of new values provided for virtual path generation.</param>
		public VirtualPathContext(HttpContext httpContext, RouteValueDictionary ambientValues, RouteValueDictionary values)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.VirtualPathContext" />.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <param name="ambientValues">The set of route values associated with the current request.</param>
		/// <param name="values">The set of new values provided for virtual path generation.</param>
		/// <param name="routeName">The name of the route to use for virtual path generation.</param>
		public VirtualPathContext(HttpContext httpContext, RouteValueDictionary ambientValues, RouteValueDictionary values, string? routeName)
		{
			throw null;
		}
	}
}
