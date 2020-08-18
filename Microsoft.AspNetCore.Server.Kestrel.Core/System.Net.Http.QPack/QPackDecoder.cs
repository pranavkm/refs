using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System.Buffers;

namespace System.Net.Http.QPack
{
	internal class QPackDecoder : IDisposable
	{
		private enum State
		{
			RequiredInsertCount,
			RequiredInsertCountContinue,
			Base,
			BaseContinue,
			CompressedHeaders,
			HeaderFieldIndex,
			HeaderNameIndex,
			HeaderNameLength,
			HeaderNameLengthContinue,
			HeaderName,
			HeaderValueLength,
			HeaderValueLengthContinue,
			HeaderValue,
			DynamicTableSizeUpdate,
			PostBaseIndex,
			LiteralHeaderFieldWithNameReference,
			HeaderNameIndexPostBase
		}

		public QPackDecoder(int maxHeadersLength)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public void Decode(in ReadOnlySequence<byte> headerBlock, Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.IHttpHeadersHandler handler)
		{
			throw null;
		}

		public void Decode(ReadOnlySpan<byte> headerBlock, Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.IHttpHeadersHandler handler)
		{
			throw null;
		}
	}
}
