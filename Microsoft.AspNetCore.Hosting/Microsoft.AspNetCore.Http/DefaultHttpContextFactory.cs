using Microsoft.AspNetCore.Http.Features;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	public class DefaultHttpContextFactory : IHttpContextFactory
	{
		internal IHttpContextAccessor? HttpContextAccessor
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		public DefaultHttpContextFactory(IServiceProvider serviceProvider)
		{
			throw null;
		}

		public HttpContext Create(IFeatureCollection featureCollection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Initialize(DefaultHttpContext httpContext, IFeatureCollection featureCollection)
		{
			throw null;
		}

		public void Dispose(HttpContext httpContext)
		{
			throw null;
		}

		internal void Dispose(DefaultHttpContext httpContext)
		{
			throw null;
		}
	}
}
