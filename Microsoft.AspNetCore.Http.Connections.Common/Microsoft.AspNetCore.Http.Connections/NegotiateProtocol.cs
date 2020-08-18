using System;
using System.Buffers;
using System.IO;

namespace Microsoft.AspNetCore.Http.Connections
{
	public static class NegotiateProtocol
	{
		public static void WriteResponse(NegotiationResponse response, IBufferWriter<byte> output)
		{
			throw null;
		}

		public static NegotiationResponse ParseResponse(ReadOnlySpan<byte> content)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		///     This method is obsolete and will be removed in a future version.
		///     The recommended alternative is <see cref="M:Microsoft.AspNetCore.Http.Connections.NegotiateProtocol.ParseResponse(System.ReadOnlySpan{System.Byte})" />.
		/// </para>
		/// </summary>
		[Obsolete("This method is obsolete and will be removed in a future version. The recommended alternative is ParseResponse(ReadOnlySpan{byte}).")]
		public static NegotiationResponse ParseResponse(Stream content)
		{
			throw null;
		}
	}
}
