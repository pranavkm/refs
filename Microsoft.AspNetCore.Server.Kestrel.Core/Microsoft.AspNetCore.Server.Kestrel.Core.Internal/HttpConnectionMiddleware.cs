using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class HttpConnectionMiddleware<TContext>
	{
		public HttpConnectionMiddleware(ServiceContext serviceContext, IHttpApplication<TContext> application, HttpProtocols protocols)
		{
			throw null;
		}

		public Task OnConnectionAsync(ConnectionContext connectionContext)
		{
			throw null;
		}
	}
}
