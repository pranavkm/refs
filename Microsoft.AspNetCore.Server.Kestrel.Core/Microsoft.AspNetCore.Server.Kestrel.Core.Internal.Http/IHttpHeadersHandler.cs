using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	public interface IHttpHeadersHandler
	{
		void OnStaticIndexedHeader(int index);

		void OnStaticIndexedHeader(int index, ReadOnlySpan<byte> value);

		void OnHeader(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value);

		void OnHeadersComplete(bool endStream);
	}
}
