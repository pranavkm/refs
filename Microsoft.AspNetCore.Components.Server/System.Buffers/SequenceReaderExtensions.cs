using System.Runtime.CompilerServices;

namespace System.Buffers
{
	internal static class SequenceReaderExtensions
	{
		/// <summary>
		/// Try to read the given type out of the buffer if possible. Warning: this is dangerous to use with arbitrary
		/// structs- see remarks for full details.
		/// </summary>
		/// <remarks>
		/// IMPORTANT: The read is a straight copy of bits. If a struct depends on specific state of its members to
		/// behave correctly this can lead to exceptions, etc. If reading endian specific integers, use the explicit
		/// overloads such as <see cref="M:System.Buffers.SequenceReaderExtensions.TryReadBigEndian(System.Buffers.SequenceReader{System.Byte}@,System.Int16@)" />.
		/// </remarks>
		/// <returns>
		/// True if successful. <paramref name="value" /> will be default if failed (due to lack of space).
		/// </returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool TryRead<T>(this ref SequenceReader<byte> reader, out T value) where T : unmanaged
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.SByte" /> from the next position in the sequence.
		/// </summary>
		/// <param name="reader">The reader to read from.</param>
		/// <param name="value">Receives the value read.</param>
		/// <returns><c>true</c> if there was another byte in the sequence; <c>false</c> otherwise.</returns>
		public static bool TryRead(this ref SequenceReader<byte> reader, out sbyte value)
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Int16" /> as big endian.
		/// </summary>
		/// <returns>False if there wasn't enough data for an <see cref="T:System.Int16" />.</returns>
		public static bool TryReadBigEndian(this ref SequenceReader<byte> reader, out short value)
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.UInt16" /> as big endian.
		/// </summary>
		/// <returns>False if there wasn't enough data for an <see cref="T:System.UInt16" />.</returns>
		public static bool TryReadBigEndian(this ref SequenceReader<byte> reader, out ushort value)
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Int32" /> as big endian.
		/// </summary>
		/// <returns>False if there wasn't enough data for an <see cref="T:System.Int32" />.</returns>
		public static bool TryReadBigEndian(this ref SequenceReader<byte> reader, out int value)
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.UInt32" /> as big endian.
		/// </summary>
		/// <returns>False if there wasn't enough data for an <see cref="T:System.UInt32" />.</returns>
		public static bool TryReadBigEndian(this ref SequenceReader<byte> reader, out uint value)
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Int64" /> as big endian.
		/// </summary>
		/// <returns>False if there wasn't enough data for an <see cref="T:System.Int64" />.</returns>
		public static bool TryReadBigEndian(this ref SequenceReader<byte> reader, out long value)
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.UInt64" /> as big endian.
		/// </summary>
		/// <returns>False if there wasn't enough data for an <see cref="T:System.UInt64" />.</returns>
		public static bool TryReadBigEndian(this ref SequenceReader<byte> reader, out ulong value)
		{
			throw null;
		}

		/// <summary>
		/// Reads a <see cref="T:System.Single" /> as big endian.
		/// </summary>
		/// <returns>False if there wasn't enough data for a <see cref="T:System.Single" />.</returns>
		public static bool TryReadBigEndian(this ref SequenceReader<byte> reader, out float value)
		{
			throw null;
		}

		/// <summary>
		/// Reads a <see cref="T:System.Double" /> as big endian.
		/// </summary>
		/// <returns>False if there wasn't enough data for a <see cref="T:System.Double" />.</returns>
		public static bool TryReadBigEndian(this ref SequenceReader<byte> reader, out double value)
		{
			throw null;
		}
	}
}
