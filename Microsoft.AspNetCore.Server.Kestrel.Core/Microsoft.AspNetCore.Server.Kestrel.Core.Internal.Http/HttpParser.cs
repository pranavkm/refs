using System.Buffers;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	public class HttpParser<TRequestHandler> : IHttpParser<TRequestHandler> where TRequestHandler : IHttpHeadersHandler, IHttpRequestLineHandler
	{
		public HttpParser()
		{
			throw null;
		}

		public HttpParser(bool showErrorDetails)
		{
			throw null;
		}

		public bool ParseRequestLine(TRequestHandler handler, ref SequenceReader<byte> reader)
		{
			throw null;
		}

		public bool ParseHeaders(TRequestHandler handler, ref SequenceReader<byte> reader)
		{
			throw null;
		}
	}
}
