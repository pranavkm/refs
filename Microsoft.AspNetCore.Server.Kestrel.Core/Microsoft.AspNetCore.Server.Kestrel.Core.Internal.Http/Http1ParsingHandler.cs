using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal readonly struct Http1ParsingHandler : IHttpRequestLineHandler, IHttpHeadersHandler
	{
		public readonly Http1Connection Connection;

		public readonly bool Trailers;

		public Http1ParsingHandler(Http1Connection connection)
		{
			throw null;
		}

		public Http1ParsingHandler(Http1Connection connection, bool trailers)
		{
			throw null;
		}

		public void OnHeader(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public void OnHeadersComplete(bool endStream)
		{
			throw null;
		}

		public void OnStartLine(HttpVersionAndMethod versionAndMethod, TargetOffsetPathLength targetPath, Span<byte> startLine)
		{
			throw null;
		}

		public void OnStaticIndexedHeader(int index)
		{
			throw null;
		}

		public void OnStaticIndexedHeader(int index, ReadOnlySpan<byte> value)
		{
			throw null;
		}
	}
}
