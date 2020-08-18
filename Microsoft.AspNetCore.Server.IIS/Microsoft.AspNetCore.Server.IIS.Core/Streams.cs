using System;
using System.IO;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class Streams
	{
		public Streams(IISHttpContext context)
		{
			throw null;
		}

		public Stream Upgrade()
		{
			throw null;
		}

		public (Stream request, Stream response) Start()
		{
			throw null;
		}

		public void Stop()
		{
			throw null;
		}

		public void Abort(Exception error)
		{
			throw null;
		}
	}
}
