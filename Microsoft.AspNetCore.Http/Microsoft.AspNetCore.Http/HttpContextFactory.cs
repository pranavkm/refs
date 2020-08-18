using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Represents methods used to create an HTTP context object. 
	/// </summary>
	[Obsolete("This is obsolete and will be removed in a future version. Use DefaultHttpContextFactory instead.")]
	public class HttpContextFactory : IHttpContextFactory
	{
		/// <summary>
		/// Initializes a new instance of the HttpContext class with options passed in.
		/// </summary>
		/// <param name="formOptions">Options to set when instantianting the HTTP context object.</param>
		public HttpContextFactory(IOptions<FormOptions> formOptions)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the DefaultHttpContext class with options passed in.
		/// </summary>
		/// <param name="formOptions">Options to set when instantianting the HTTP context object.</param>
		/// <param name="serviceScopeFactory">Factory object used to create the service scope for the HTTP context.</param>
		public HttpContextFactory(IOptions<FormOptions> formOptions, IServiceScopeFactory serviceScopeFactory)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the DefaultHttpContext class with options passed in.
		/// </summary>
		/// <param name="formOptions">Options to set when instantianting the HTTP context object.</param>
		/// <param name="httpContextAccessor">Object to be used to access the HTTP context instance.</param>
		public HttpContextFactory(IOptions<FormOptions> formOptions, IHttpContextAccessor? httpContextAccessor)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the DefaultHttpContext class with options passed in.
		/// </summary>
		/// <param name="formOptions">Options to set when instantianting the HTTP context object.</param>
		/// <param name="serviceScopeFactory">Factory object used to create the service scope for the HTTP context.</param>
		/// <param name="httpContextAccessor">Options to set when instantianting the Default HTTP context object.</param>
		public HttpContextFactory(IOptions<FormOptions> formOptions, IServiceScopeFactory serviceScopeFactory, IHttpContextAccessor? httpContextAccessor)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the DefaultHttpContext class with options passed in.
		/// </summary>
		/// <param name="featureCollection">Options to set when instantianting the Default HTTP context object.</param>
		public HttpContext Create(IFeatureCollection featureCollection)
		{
			throw null;
		}

		/// <summary>
		/// Sets the HTTP context object to null for garbage collection. 
		/// </summary>
		/// <param name="httpContext">HTTP context to dispose.</param>
		public void Dispose(HttpContext httpContext)
		{
			throw null;
		}
	}
}
