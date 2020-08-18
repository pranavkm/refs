using System.Buffers;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Internal
{
	internal static class TextMessageParser
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryParseMessage(ref ReadOnlySequence<byte> buffer, out ReadOnlySequence<byte> payload)
		{
			throw null;
		}
	}
}
