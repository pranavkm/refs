using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System;
using System.IO;
using System.IO.Pipelines;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class BodyControl
	{
		public BodyControl(IHttpBodyControlFeature bodyControl, IHttpResponseControl responseControl)
		{
			throw null;
		}

		public Stream Upgrade()
		{
			throw null;
		}

		public (Stream request, Stream response, PipeReader reader, PipeWriter writer) Start(MessageBody body)
		{
			throw null;
		}

		public Task StopAsync()
		{
			throw null;
		}

		public void Abort(Exception error)
		{
			throw null;
		}
	}
}
