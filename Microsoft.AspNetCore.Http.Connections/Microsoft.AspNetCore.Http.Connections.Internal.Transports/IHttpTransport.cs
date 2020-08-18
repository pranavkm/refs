using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Connections.Internal.Transports
{
	internal interface IHttpTransport
	{
		/// <summary>
		/// Executes the transport
		/// </summary>
		/// <param name="context"></param>
		/// <param name="token"></param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when the transport has finished processing</returns>
		Task ProcessRequestAsync(HttpContext context, CancellationToken token);
	}
}
