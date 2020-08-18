using Microsoft.AspNetCore.Server.Kestrel.Core.Internal;
using System;
using System.IO;
using System.IO.Pipelines;
using System.Net.Security;

namespace Microsoft.AspNetCore.Server.Kestrel.Https.Internal
{
	internal class SslDuplexPipe : DuplexPipeStreamAdapter<SslStream>
	{
		public SslDuplexPipe(IDuplexPipe transport, StreamPipeReaderOptions readerOptions, StreamPipeWriterOptions writerOptions)
		{
			throw null;
		}

		public SslDuplexPipe(IDuplexPipe transport, StreamPipeReaderOptions readerOptions, StreamPipeWriterOptions writerOptions, Func<Stream, SslStream> factory)
		{
			throw null;
		}
	}
}
