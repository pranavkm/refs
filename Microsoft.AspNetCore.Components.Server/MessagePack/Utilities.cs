using System;
using System.Buffers;

namespace MessagePack
{
	/// <summary>
	/// Internal utilities and extension methods for various external types.
	/// </summary>
	internal static class Utilities
	{
		internal delegate void GetWriterBytesAction<TArg>(ref MessagePackWriter writer, TArg argument);

		/// <summary>
		/// A value indicating whether we're running on mono.
		/// </summary>
		internal static readonly bool IsMono;

		internal static byte[] GetWriterBytes<TArg>(TArg arg, GetWriterBytesAction<TArg> action)
		{
			throw null;
		}

		internal static Memory<T> GetMemoryCheckResult<T>(this IBufferWriter<T> bufferWriter, int size = 0)
		{
			throw null;
		}
	}
}
