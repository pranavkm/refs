using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Threading;

namespace MessagePack
{
	/// <summary>
	/// A primitive types writer for the MessagePack format.
	/// </summary>
	/// <remarks>
	/// <see href="https://github.com/msgpack/msgpack/blob/master/spec.md">The MessagePack spec.</see>.
	/// </remarks>
	internal ref struct MessagePackWriter
	{
		/// <summary>
		/// The writer to use.
		/// </summary>
		private BufferWriter writer;

		/// <summary>
		/// Gets or sets the cancellation token for this serialization operation.
		/// </summary>
		public CancellationToken CancellationToken
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether to write in <see href="https://github.com/msgpack/msgpack/blob/master/spec-old.md">old spec</see> compatibility mode.
		/// </summary>
		public bool OldSpec
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackWriter" /> struct.
		/// </summary>
		/// <param name="writer">The writer to use.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public MessagePackWriter(IBufferWriter<byte> writer)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackWriter" /> struct.
		/// </summary>
		/// <param name="sequencePool">The pool from which to draw an <see cref="T:System.Buffers.IBufferWriter`1" /> if required..</param>
		/// <param name="array">An array to start with so we can avoid accessing the <paramref name="sequencePool" /> if possible.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		internal MessagePackWriter(SequencePool sequencePool, byte[] array)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackWriter" /> struct,
		/// with the same settings as this one, but with its own buffer writer.
		/// </summary>
		/// <param name="writer">The writer to use for the new instance.</param>
		/// <returns>The new writer.</returns>
		public MessagePackWriter Clone(IBufferWriter<byte> writer)
		{
			throw null;
		}

		/// <summary>
		/// Ensures everything previously written has been flushed to the underlying <see cref="T:System.Buffers.IBufferWriter`1" />.
		/// </summary>
		public void Flush()
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="F:MessagePack.MessagePackCode.Nil" /> value.
		/// </summary>
		public void WriteNil()
		{
			throw null;
		}

		/// <summary>
		/// Copies bytes directly into the message pack writer.
		/// </summary>
		/// <param name="rawMessagePackBlock">The span of bytes to copy from.</param>
		public void WriteRaw(ReadOnlySpan<byte> rawMessagePackBlock)
		{
			throw null;
		}

		/// <summary>
		/// Copies bytes directly into the message pack writer.
		/// </summary>
		/// <param name="rawMessagePackBlock">The span of bytes to copy from.</param>
		public void WriteRaw(in ReadOnlySequence<byte> rawMessagePackBlock)
		{
			throw null;
		}

		/// <summary>
		/// Write the length of the next array to be written in the most compact form of
		/// <see cref="F:MessagePack.MessagePackCode.MinFixArray" />,
		/// <see cref="F:MessagePack.MessagePackCode.Array16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Array32" />.
		/// </summary>
		/// <param name="count">The number of elements that will be written in the array.</param>
		public void WriteArrayHeader(int count)
		{
			throw null;
		}

		/// <summary>
		/// Write the length of the next array to be written in the most compact form of
		/// <see cref="F:MessagePack.MessagePackCode.MinFixArray" />,
		/// <see cref="F:MessagePack.MessagePackCode.Array16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Array32" />.
		/// </summary>
		/// <param name="count">The number of elements that will be written in the array.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void WriteArrayHeader(uint count)
		{
			throw null;
		}

		/// <summary>
		/// Write the length of the next map to be written in the most compact form of
		/// <see cref="F:MessagePack.MessagePackCode.MinFixMap" />,
		/// <see cref="F:MessagePack.MessagePackCode.Map16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Map32" />.
		/// </summary>
		/// <param name="count">The number of key=value pairs that will be written in the map.</param>
		public void WriteMapHeader(int count)
		{
			throw null;
		}

		/// <summary>
		/// Write the length of the next map to be written in the most compact form of
		/// <see cref="F:MessagePack.MessagePackCode.MinFixMap" />,
		/// <see cref="F:MessagePack.MessagePackCode.Map16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Map32" />.
		/// </summary>
		/// <param name="count">The number of key=value pairs that will be written in the map.</param>
		public void WriteMapHeader(uint count)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.Byte" /> value using a 1-byte code when possible, otherwise as <see cref="F:MessagePack.MessagePackCode.UInt8" />.
		/// </summary>
		/// <param name="value">The value.</param>
		public void Write(byte value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.Byte" /> value using <see cref="F:MessagePack.MessagePackCode.UInt8" />.
		/// </summary>
		/// <param name="value">The value.</param>
		public void WriteUInt8(byte value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an 8-bit value using a 1-byte code when possible, otherwise as <see cref="F:MessagePack.MessagePackCode.Int8" />.
		/// </summary>
		/// <param name="value">The value.</param>
		public void Write(sbyte value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an 8-bit value using <see cref="F:MessagePack.MessagePackCode.Int8" />.
		/// </summary>
		/// <param name="value">The value.</param>
		public void WriteInt8(sbyte value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.UInt16" /> value using a 1-byte code when possible, otherwise as <see cref="F:MessagePack.MessagePackCode.UInt8" /> or <see cref="F:MessagePack.MessagePackCode.UInt16" />.
		/// </summary>
		/// <param name="value">The value.</param>
		public void Write(ushort value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.UInt16" /> value using <see cref="F:MessagePack.MessagePackCode.UInt16" />.
		/// </summary>
		/// <param name="value">The value.</param>
		public void WriteUInt16(ushort value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.Int16" /> using a built-in 1-byte code when within specific MessagePack-supported ranges,
		/// or the most compact of
		/// <see cref="F:MessagePack.MessagePackCode.UInt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int8" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Int16" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void Write(short value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.Int16" /> using <see cref="F:MessagePack.MessagePackCode.Int16" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void WriteInt16(short value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an <see cref="T:System.UInt32" /> using a built-in 1-byte code when within specific MessagePack-supported ranges,
		/// or the most compact of
		/// <see cref="F:MessagePack.MessagePackCode.UInt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.UInt32" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write(uint value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an <see cref="T:System.UInt32" /> using <see cref="F:MessagePack.MessagePackCode.UInt32" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void WriteUInt32(uint value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an <see cref="T:System.Int32" /> using a built-in 1-byte code when within specific MessagePack-supported ranges,
		/// or the most compact of
		/// <see cref="F:MessagePack.MessagePackCode.UInt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt32" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int32" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write(int value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an <see cref="T:System.Int32" /> using <see cref="F:MessagePack.MessagePackCode.Int32" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void WriteInt32(int value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an <see cref="T:System.UInt64" /> using a built-in 1-byte code when within specific MessagePack-supported ranges,
		/// or the most compact of
		/// <see cref="F:MessagePack.MessagePackCode.UInt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt32" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int32" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void Write(ulong value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an <see cref="T:System.UInt64" /> using <see cref="F:MessagePack.MessagePackCode.Int32" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void WriteUInt64(ulong value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an <see cref="T:System.Int64" /> using a built-in 1-byte code when within specific MessagePack-supported ranges,
		/// or the most compact of
		/// <see cref="F:MessagePack.MessagePackCode.UInt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt32" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt64" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int32" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int64" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void Write(long value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.Int64" /> using <see cref="F:MessagePack.MessagePackCode.Int64" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void WriteInt64(long value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.Boolean" /> value using either <see cref="F:MessagePack.MessagePackCode.True" /> or <see cref="F:MessagePack.MessagePackCode.False" />.
		/// </summary>
		/// <param name="value">The value.</param>
		public void Write(bool value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.Char" /> value using a 1-byte code when possible, otherwise as <see cref="F:MessagePack.MessagePackCode.UInt8" /> or <see cref="F:MessagePack.MessagePackCode.UInt16" />.
		/// </summary>
		/// <param name="value">The value.</param>
		public void Write(char value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="F:MessagePack.MessagePackCode.Float32" /> value.
		/// </summary>
		/// <param name="value">The value.</param>
		public void Write(float value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="F:MessagePack.MessagePackCode.Float64" /> value.
		/// </summary>
		/// <param name="value">The value.</param>
		public void Write(double value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.DateTime" /> using the message code <see cref="F:MessagePack.ReservedMessagePackExtensionTypeCode.DateTime" />.
		/// </summary>
		/// <param name="dateTime">The value to write.</param>
		/// <exception cref="T:System.NotSupportedException">Thrown when <see cref="P:MessagePack.MessagePackWriter.OldSpec" /> is true because the old spec does not define a <see cref="T:System.DateTime" /> format.</exception>
		public void Write(DateTime dateTime)
		{
			throw null;
		}

		/// <summary>
		/// Writes a <see cref="T:System.Byte" />[], prefixed with a length encoded as the smallest fitting from:
		/// <see cref="F:MessagePack.MessagePackCode.Bin8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Bin16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Bin32" />,
		/// or <see cref="F:MessagePack.MessagePackCode.Nil" /> if <paramref name="src" /> is <c>null</c>.
		/// </summary>
		/// <param name="src">The array of bytes to write. May be <c>null</c>.</param>
		public void Write(byte[] src)
		{
			throw null;
		}

		/// <summary>
		/// Writes a span of bytes, prefixed with a length encoded as the smallest fitting from:
		/// <see cref="F:MessagePack.MessagePackCode.Bin8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Bin16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Bin32" />.
		/// </summary>
		/// <param name="src">The span of bytes to write.</param>
		/// <remarks>
		/// When <see cref="P:MessagePack.MessagePackWriter.OldSpec" /> is <c>true</c>, the msgpack code used is <see cref="F:MessagePack.MessagePackCode.Str8" />, <see cref="F:MessagePack.MessagePackCode.Str16" /> or <see cref="F:MessagePack.MessagePackCode.Str32" /> instead.
		/// </remarks>
		public void Write(ReadOnlySpan<byte> src)
		{
			throw null;
		}

		/// <summary>
		/// Writes a sequence of bytes, prefixed with a length encoded as the smallest fitting from:
		/// <see cref="F:MessagePack.MessagePackCode.Bin8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Bin16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Bin32" />.
		/// </summary>
		/// <param name="src">The span of bytes to write.</param>
		/// <remarks>
		/// When <see cref="P:MessagePack.MessagePackWriter.OldSpec" /> is <c>true</c>, the msgpack code used is <see cref="F:MessagePack.MessagePackCode.Str8" />, <see cref="F:MessagePack.MessagePackCode.Str16" /> or <see cref="F:MessagePack.MessagePackCode.Str32" /> instead.
		/// </remarks>
		public void Write(in ReadOnlySequence<byte> src)
		{
			throw null;
		}

		/// <summary>
		/// Writes the header that precedes a raw binary sequence with a length encoded as the smallest fitting from:
		/// <see cref="F:MessagePack.MessagePackCode.Bin8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Bin16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Bin32" />.
		/// </summary>
		/// <param name="length">The length of bytes that will be written next.</param>
		/// <remarks>
		/// <para>
		/// The caller should use <see cref="M:MessagePack.MessagePackWriter.WriteRaw(System.Buffers.ReadOnlySequence{System.Byte}@)" /> or <see cref="M:MessagePack.MessagePackWriter.WriteRaw(System.ReadOnlySpan{System.Byte})" />
		/// after calling this method to actually write the content.
		/// Alternatively a single call to <see cref="M:MessagePack.MessagePackWriter.Write(System.ReadOnlySpan{System.Byte})" /> or <see cref="M:MessagePack.MessagePackWriter.Write(System.Buffers.ReadOnlySequence{System.Byte}@)" /> will take care of the header and content in one call.
		/// </para>
		/// <para>
		/// When <see cref="P:MessagePack.MessagePackWriter.OldSpec" /> is <c>true</c>, the msgpack code used is <see cref="F:MessagePack.MessagePackCode.Str8" />, <see cref="F:MessagePack.MessagePackCode.Str16" /> or <see cref="F:MessagePack.MessagePackCode.Str32" /> instead.
		/// </para>
		/// </remarks>
		public void WriteBinHeader(int length)
		{
			throw null;
		}

		/// <summary>
		/// Writes out an array of bytes that (may) represent a UTF-8 encoded string, prefixed with the length using one of these message codes:
		/// <see cref="F:MessagePack.MessagePackCode.MinFixStr" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />.
		/// </summary>
		/// <param name="utf8stringBytes">The bytes to write.</param>
		public void WriteString(in ReadOnlySequence<byte> utf8stringBytes)
		{
			throw null;
		}

		/// <summary>
		/// Writes out an array of bytes that (may) represent a UTF-8 encoded string, prefixed with the length using one of these message codes:
		/// <see cref="F:MessagePack.MessagePackCode.MinFixStr" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />.
		/// </summary>
		/// <param name="utf8stringBytes">The bytes to write.</param>
		public void WriteString(ReadOnlySpan<byte> utf8stringBytes)
		{
			throw null;
		}

		/// <summary>
		/// Writes out the header that may precede a UTF-8 encoded string, prefixed with the length using one of these message codes:
		/// <see cref="F:MessagePack.MessagePackCode.MinFixStr" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />.
		/// </summary>
		/// <param name="byteCount">The number of bytes in the string that will follow this header.</param>
		/// <remarks>
		/// The caller should use <see cref="M:MessagePack.MessagePackWriter.WriteRaw(System.Buffers.ReadOnlySequence{System.Byte}@)" /> or <see cref="M:MessagePack.MessagePackWriter.WriteRaw(System.ReadOnlySpan{System.Byte})" />
		/// after calling this method to actually write the content.
		/// Alternatively a single call to <see cref="M:MessagePack.MessagePackWriter.WriteString(System.ReadOnlySpan{System.Byte})" /> or <see cref="M:MessagePack.MessagePackWriter.WriteString(System.Buffers.ReadOnlySequence{System.Byte}@)" /> will take care of the header and content in one call.
		/// </remarks>
		public void WriteStringHeader(int byteCount)
		{
			throw null;
		}

		/// <summary>
		/// Writes out a <see cref="T:System.String" />, prefixed with the length using one of these message codes:
		/// <see cref="F:MessagePack.MessagePackCode.MinFixStr" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />,
		/// or <see cref="F:MessagePack.MessagePackCode.Nil" /> if the <paramref name="value" /> is <c>null</c>.
		/// </summary>
		/// <param name="value">The value to write. May be null.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write(string value)
		{
			throw null;
		}

		/// <summary>
		/// Writes out a <see cref="T:System.String" />, prefixed with the length using one of these message codes:
		/// <see cref="F:MessagePack.MessagePackCode.MinFixStr" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />.
		/// </summary>
		/// <param name="value">The value to write.</param>
		public void Write(ReadOnlySpan<char> value)
		{
			throw null;
		}

		/// <summary>
		/// Writes the extension format header, using the smallest one of these codes:
		/// <see cref="F:MessagePack.MessagePackCode.FixExt1" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt2" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt4" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Ext32" />.
		/// </summary>
		/// <param name="extensionHeader">The extension header.</param>
		public void WriteExtensionFormatHeader(ExtensionHeader extensionHeader)
		{
			throw null;
		}

		/// <summary>
		/// Writes an extension format, using the smallest one of these codes:
		/// <see cref="F:MessagePack.MessagePackCode.FixExt1" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt2" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt4" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Ext32" />.
		/// </summary>
		/// <param name="extensionData">The extension data.</param>
		public void WriteExtensionFormat(ExtensionResult extensionData)
		{
			throw null;
		}

		/// <summary>
		/// Gets memory where raw messagepack data can be written.
		/// </summary>
		/// <param name="length">The size of the memory block required.</param>
		/// <returns>The span of memory to write to. This *may* exceed <paramref name="length" />.</returns>
		/// <remarks>
		/// <para>After initializing the resulting memory, always follow up with a call to <see cref="M:MessagePack.MessagePackWriter.Advance(System.Int32)" />.</para>
		/// <para>
		/// This is similar in purpose to <see cref="M:MessagePack.MessagePackWriter.WriteRaw(System.ReadOnlySpan{System.Byte})" />
		/// but provides uninitialized memory for the caller to write to instead of copying initialized memory from elsewhere.
		/// </para>
		/// </remarks>
		/// <seealso cref="M:System.Buffers.IBufferWriter`1.GetSpan(System.Int32)" />
		public Span<byte> GetSpan(int length)
		{
			throw null;
		}

		/// <summary>
		/// Commits memory previously returned from <see cref="M:MessagePack.MessagePackWriter.GetSpan(System.Int32)" /> as initialized.
		/// </summary>
		/// <param name="length">The number of bytes initialized with messagepack data from the previously returned span.</param>
		/// <seealso cref="M:System.Buffers.IBufferWriter`1.Advance(System.Int32)" />
		public void Advance(int length)
		{
			throw null;
		}

		/// <summary>
		/// Writes a 16-bit integer in big endian format.
		/// </summary>
		/// <param name="value">The integer.</param>
		internal void WriteBigEndian(ushort value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a 32-bit integer in big endian format.
		/// </summary>
		/// <param name="value">The integer.</param>
		internal void WriteBigEndian(uint value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a 64-bit integer in big endian format.
		/// </summary>
		/// <param name="value">The integer.</param>
		internal void WriteBigEndian(ulong value)
		{
			throw null;
		}

		internal byte[] FlushAndGetArray()
		{
			throw null;
		}
	}
}
