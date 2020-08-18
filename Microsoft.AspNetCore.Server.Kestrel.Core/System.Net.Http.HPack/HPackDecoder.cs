using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.Net.Http.HPack
{
	internal class HPackDecoder
	{
		private enum State : byte
		{
			Ready,
			HeaderFieldIndex,
			HeaderNameIndex,
			HeaderNameLength,
			HeaderNameLengthContinue,
			HeaderName,
			HeaderValueLength,
			HeaderValueLengthContinue,
			HeaderValue,
			DynamicTableSizeUpdate
		}

		public const int DefaultHeaderTableSize = 4096;

		public const int DefaultStringOctetsSize = 4096;

		public const int DefaultMaxHeadersLength = 65536;

		public HPackDecoder(int maxDynamicTableSize = 4096, int maxHeadersLength = 65536)
		{
			throw null;
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		internal HPackDecoder(int maxDynamicTableSize, int maxHeadersLength, DynamicTable dynamicTable)
		{
			throw null;
		}

		public void Decode(in ReadOnlySequence<byte> data, bool endHeaders, Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.IHttpHeadersHandler handler)
		{
			throw null;
		}

		public void Decode(ReadOnlySpan<byte> data, bool endHeaders, Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.IHttpHeadersHandler handler)
		{
			throw null;
		}

		public void CompleteDecode()
		{
			throw null;
		}
	}
}
