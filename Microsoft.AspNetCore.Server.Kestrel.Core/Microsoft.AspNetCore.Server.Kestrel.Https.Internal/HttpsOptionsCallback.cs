using Microsoft.AspNetCore.Connections;
using System.Net.Security;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Https.Internal
{
	internal delegate ValueTask<SslServerAuthenticationOptions> HttpsOptionsCallback(ConnectionContext connection, SslStream stream, SslClientHelloInfo clientHelloInfo, object state, CancellationToken cancellationToken);
}
