using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Features
{
	public class RequestServicesFeature : IServiceProvidersFeature, IDisposable, IAsyncDisposable
	{
		public IServiceProvider RequestServices
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

		public RequestServicesFeature(HttpContext context, IServiceScopeFactory? scopeFactory)
		{
			throw null;
		}

		public ValueTask DisposeAsync()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
