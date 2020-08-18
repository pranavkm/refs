using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class Http3ConnectionMiddleware<TContext>
	{
		public Http3ConnectionMiddleware(ServiceContext serviceContext, IHttpApplication<TContext> application)
		{
			throw null;
		}

		public Task OnConnectionAsync(MultiplexedConnectionContext connectionContext)
		{
			throw null;
		}
	}
}
