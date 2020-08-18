using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal interface IRequestProcessor
	{
		Task ProcessRequestsAsync<TContext>(IHttpApplication<TContext> application);

		void StopProcessingNextRequest();

		void HandleRequestHeadersTimeout();

		void HandleReadDataRateTimeout();

		void OnInputOrOutputCompleted();

		void Tick(DateTimeOffset now);

		void Abort(ConnectionAbortedException ex);
	}
}
