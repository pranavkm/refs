using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal static class HttpConnectionBuilderExtensions
	{
		public static IConnectionBuilder UseHttpServer<TContext>(this IConnectionBuilder builder, ServiceContext serviceContext, IHttpApplication<TContext> application, HttpProtocols protocols)
		{
			throw null;
		}

		public static IMultiplexedConnectionBuilder UseHttp3Server<TContext>(this IMultiplexedConnectionBuilder builder, ServiceContext serviceContext, IHttpApplication<TContext> application, HttpProtocols protocols)
		{
			throw null;
		}
	}
}
