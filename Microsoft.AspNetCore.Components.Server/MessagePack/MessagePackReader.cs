using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Threading;

namespace MessagePack
{
	/// <summary>
	/// A primitive types reader for the MessagePack format.
	/// </summary>
	/// <remarks>
	/// <see href="https://github.com/msgpack/msgpack/blob/master/spec.md">The MessagePack spec.</see>.
	/// </remarks>
	/// <exception cref="T:MessagePack.MessagePackSerializationException">Thrown when reading methods fail due to invalid data.</exception>
	/// <exception cref="T:System.IO.EndOfStreamException">Thrown by reading methods when there are not enough bytes to read the required value.</exception>
	internal ref struct MessagePackReader
	{
		/// <summary>
		/// The reader over the sequence.
		/// </summary>
		private SequenceReader<byte> reader;

		/// <summary>
		/// Gets or sets the cancellation token for this deserialization operation.
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
		/// Gets or sets the present depth of the object graph being deserialized.
		/// </summary>
		public int Depth
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
		/// Gets the <see cref="T:System.Buffers.ReadOnlySequence`1" /> originally supplied to the constructor.
		/// </summary>
		public ReadOnlySequence<byte> Sequence
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the current position of the reader within <see cref="P:MessagePack.MessagePackReader.Sequence" />.
		/// </summary>
		public SequencePosition Position
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the number of bytes consumed by the reader.
		/// </summary>
		public long Consumed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the reader is at the end of the sequence.
		/// </summary>
		public bool End
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the reader position is pointing at a nil value.
		/// </summary>
		/// <exception cref="T:System.IO.EndOfStreamException">Thrown if the end of the sequence provided to the constructor is reached before the expected end of the data.</exception>
		public bool IsNil
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the next message pack type to be read.
		/// </summary>
		public MessagePackType NextMessagePackType
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the type of the next MessagePack block.
		/// </summary>
		/// <exception cref="T:System.IO.EndOfStreamException">Thrown if the end of the sequence provided to the constructor is reached before the expected end of the data.</exception>
		/// <remarks>
		/// See <see cref="T:MessagePack.MessagePackCode" /> for valid message pack codes and ranges.
		/// </remarks>
		public byte NextCode
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackReader" /> struct.
		/// </summary>
		/// <param name="memory">The buffer to read from.</param>
		public MessagePackReader(ReadOnlyMemory<byte> memory)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackReader" /> struct.
		/// </summary>
		/// <param name="readOnlySequence">The sequence to read from.</param>
		public MessagePackReader(in ReadOnlySequence<byte> readOnlySequence)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.MessagePackReader" /> struct,
		/// with the same settings as this one, but with its own buffer to read from.
		/// </summary>
		/// <param name="readOnlySequence">The sequence to read from.</param>
		/// <returns>The new reader.</returns>
		public MessagePackReader Clone(in ReadOnlySequence<byte> readOnlySequence)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:MessagePack.MessagePackReader" /> at this reader's current position.
		/// The two readers may then be used independently without impacting each other.
		/// </summary>
		/// <returns>A new <see cref="T:MessagePack.MessagePackReader" />.</returns>
		/// <devremarks>
		/// Since this is a struct, copying it completely is as simple as returning itself
		/// from a property that isn't a "ref return" property.
		/// </devremarks>
		public MessagePackReader CreatePeekReader()
		{
			throw null;
		}

		/// <summary>
		/// Advances the reader to the next MessagePack primitive to be read.
		/// </summary>
		/// <remarks>
		/// The entire primitive is skipped, including content of maps or arrays, or any other type with payloads.
		/// To get the raw MessagePack sequence that was skipped, use <see cref="M:MessagePack.MessagePackReader.ReadRaw" /> instead.
		/// </remarks>
		public void Skip()
		{
			throw null;
		}

		/// <summary>
		/// Advances the reader to the next MessagePack primitive to be read.
		/// </summary>
		/// <returns><c>true</c> if the entire structure beginning at the current <see cref="P:MessagePack.MessagePackReader.Position" /> is found in the <see cref="P:MessagePack.MessagePackReader.Sequence" />; <c>false</c> otherwise.</returns>
		/// <remarks>
		/// The entire primitive is skipped, including content of maps or arrays, or any other type with payloads.
		/// To get the raw MessagePack sequence that was skipped, use <see cref="M:MessagePack.MessagePackReader.ReadRaw" /> instead.
		/// </remarks>
		internal bool TrySkip()
		{
			throw null;
		}

		/// <summary>
		/// Reads a <see cref="F:MessagePack.MessagePackCode.Nil" /> value.
		/// </summary>
		/// <returns>A nil value.</returns>
		public Nil ReadNil()
		{
			throw null;
		}

		/// <summary>
		/// Reads nil if it is the next token.
		/// </summary>
		/// <returns><c>true</c> if the next token was nil; <c>false</c> otherwise.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Thrown if the end of the sequence provided to the constructor is reached before the expected end of the data.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryReadNil()
		{
			throw null;
		}

		/// <summary>
		/// Reads a sequence of bytes without any decoding.
		/// </summary>
		/// <param name="length">The number of bytes to read.</param>
		/// <returns>The sequence of bytes read.</returns>
		public ReadOnlySequence<byte> ReadRaw(long length)
		{
			throw null;
		}

		/// <summary>
		/// Reads the next MessagePack primitive.
		/// </summary>
		/// <returns>The raw MessagePack sequence.</returns>
		/// <remarks>
		/// The entire primitive is read, including content of maps or arrays, or any other type with payloads.
		/// </remarks>
		public ReadOnlySequence<byte> ReadRaw()
		{
			throw null;
		}

		/// <summary>
		/// Read an array header from
		/// <see cref="F:MessagePack.MessagePackCode.Array16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Array32" />, or
		/// some built-in code between <see cref="F:MessagePack.MessagePackCode.MinFixArray" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixArray" />.
		/// </summary>
		/// <exception cref="T:System.IO.EndOfStreamException">
		/// Thrown if the header cannot be read in the bytes left in the <see cref="P:MessagePack.MessagePackReader.Sequence" />
		/// or if it is clear that there are insufficient bytes remaining after the header to include all the elements the header claims to be there.
		/// </exception>
		/// <exception cref="T:MessagePack.MessagePackSerializationException">Thrown if a code other than an array header is encountered.</exception>
		public int ReadArrayHeader()
		{
			throw null;
		}

		/// <summary>
		/// Reads an array header from
		/// <see cref="F:MessagePack.MessagePackCode.Array16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Array32" />, or
		/// some built-in code between <see cref="F:MessagePack.MessagePackCode.MinFixArray" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixArray" />
		/// if there is sufficient buffer to read it.
		/// </summary>
		/// <param name="count">Receives the number of elements in the array if the entire array header could be read.</param>
		/// <returns><c>true</c> if there was sufficient buffer and an array header was found; <c>false</c> if the buffer incompletely describes an array header.</returns>
		/// <exception cref="T:MessagePack.MessagePackSerializationException">Thrown if a code other than an array header is encountered.</exception>
		/// <remarks>
		/// When this method returns <c>false</c> the position of the reader is left in an undefined position.
		/// The caller is expected to recreate the reader (presumably with a longer sequence to read from) before continuing.
		/// </remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryReadArrayHeader(out int count)
		{
			throw null;
		}

		/// <summary>
		/// Read a map header from
		/// <see cref="F:MessagePack.MessagePackCode.Map16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Map32" />, or
		/// some built-in code between <see cref="F:MessagePack.MessagePackCode.MinFixMap" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixMap" />.
		/// </summary>
		/// <returns>The number of key=value pairs in the map.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">
		/// Thrown if the header cannot be read in the bytes left in the <see cref="P:MessagePack.MessagePackReader.Sequence" />
		/// or if it is clear that there are insufficient bytes remaining after the header to include all the elements the header claims to be there.
		/// </exception>
		/// <exception cref="T:MessagePack.MessagePackSerializationException">Thrown if a code other than an map header is encountered.</exception>
		public int ReadMapHeader()
		{
			throw null;
		}

		/// <summary>
		/// Reads a map header from
		/// <see cref="F:MessagePack.MessagePackCode.Map16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Map32" />, or
		/// some built-in code between <see cref="F:MessagePack.MessagePackCode.MinFixMap" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixMap" />
		/// if there is sufficient buffer to read it.
		/// </summary>
		/// <param name="count">Receives the number of key=value pairs in the map if the entire map header can be read.</param>
		/// <returns><c>true</c> if there was sufficient buffer and a map header was found; <c>false</c> if the buffer incompletely describes an map header.</returns>
		/// <exception cref="T:MessagePack.MessagePackSerializationException">Thrown if a code other than an map header is encountered.</exception>
		/// <remarks>
		/// When this method returns <c>false</c> the position of the reader is left in an undefined position.
		/// The caller is expected to recreate the reader (presumably with a longer sequence to read from) before continuing.
		/// </remarks>
		public bool TryReadMapHeader(out int count)
		{
			throw null;
		}

		/// <summary>
		/// Reads a boolean value from either a <see cref="F:MessagePack.MessagePackCode.False" /> or <see cref="F:MessagePack.MessagePackCode.True" />.
		/// </summary>
		/// <returns>The value.</returns>
		public bool ReadBoolean()
		{
			throw null;
		}

		/// <summary>
		/// Reads a <see cref="T:System.Char" /> from any of:
		/// <see cref="F:MessagePack.MessagePackCode.UInt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt16" />,
		/// or anything between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />.
		/// </summary>
		/// <returns>A character.</returns>
		public char ReadChar()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Single" /> value from any value encoded with:
		/// <see cref="F:MessagePack.MessagePackCode.Float32" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int32" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int64" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt32" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt64" />,
		/// or some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// or some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />.
		/// </summary>
		/// <returns>The value.</returns>
		public float ReadSingle()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Double" /> value from any value encoded with:
		/// <see cref="F:MessagePack.MessagePackCode.Float64" />,
		/// <see cref="F:MessagePack.MessagePackCode.Float32" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int32" />,
		/// <see cref="F:MessagePack.MessagePackCode.Int64" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt32" />,
		/// <see cref="F:MessagePack.MessagePackCode.UInt64" />,
		/// or some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// or some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />.
		/// </summary>
		/// <returns>The value.</returns>
		public double ReadDouble()
		{
			throw null;
		}

		/// <summary>
		/// Reads a <see cref="T:System.DateTime" /> from a value encoded with
		/// <see cref="F:MessagePack.MessagePackCode.FixExt4" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt8" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Ext8" />.
		/// Expects extension type code <see cref="F:MessagePack.ReservedMessagePackExtensionTypeCode.DateTime" />.
		/// </summary>
		/// <returns>The value.</returns>
		public DateTime ReadDateTime()
		{
			throw null;
		}

		/// <summary>
		/// Reads a <see cref="T:System.DateTime" /> from a value encoded with
		/// <see cref="F:MessagePack.MessagePackCode.FixExt4" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext8" />.
		/// Expects extension type code <see cref="F:MessagePack.ReservedMessagePackExtensionTypeCode.DateTime" />.
		/// </summary>
		/// <param name="header">The extension header that was already read.</param>
		/// <returns>The value.</returns>
		public DateTime ReadDateTime(ExtensionHeader header)
		{
			throw null;
		}

		/// <summary>
		/// Reads a span of bytes, whose length is determined by a header of one of these types:
		/// <see cref="F:MessagePack.MessagePackCode.Bin8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Bin16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Bin32" />,
		/// or to support OldSpec compatibility:
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />,
		/// or something beteween <see cref="F:MessagePack.MessagePackCode.MinFixStr" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixStr" />.
		/// </summary>
		/// <returns>
		/// A sequence of bytes, or <c>null</c> if the read token is <see cref="F:MessagePack.MessagePackCode.Nil" />.
		/// The data is a slice from the original sequence passed to this reader's constructor.
		/// </returns>
		public ReadOnlySequence<byte>? ReadBytes()
		{
			throw null;
		}

		/// <summary>
		/// Reads a string of bytes, whose length is determined by a header of one of these types:
		/// <see cref="F:MessagePack.MessagePackCode.Str8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />,
		/// or a code between <see cref="F:MessagePack.MessagePackCode.MinFixStr" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixStr" />.
		/// </summary>
		/// <returns>
		/// The sequence of bytes, or <c>null</c> if the read token is <see cref="F:MessagePack.MessagePackCode.Nil" />.
		/// The data is a slice from the original sequence passed to this reader's constructor.
		/// </returns>
		public ReadOnlySequence<byte>? ReadStringSequence()
		{
			throw null;
		}

		/// <summary>
		/// Reads a string of bytes, whose length is determined by a header of one of these types:
		/// <see cref="F:MessagePack.MessagePackCode.Str8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />,
		/// or a code between <see cref="F:MessagePack.MessagePackCode.MinFixStr" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixStr" />.
		/// </summary>
		/// <param name="span">Receives the span to the string.</param>
		/// <returns>
		/// <c>true</c> if the string is contiguous in memory such that it could be set as a single span.
		/// <c>false</c> if the read token is <see cref="F:MessagePack.MessagePackCode.Nil" /> or the string is not in a contiguous span.
		/// </returns>
		/// <remarks>
		/// Callers should generally be prepared for a <c>false</c> result and failover to calling <see cref="M:MessagePack.MessagePackReader.ReadStringSequence" />
		/// which can represent a <c>null</c> result and handle strings that are not contiguous in memory.
		/// </remarks>
		public bool TryReadStringSpan(out ReadOnlySpan<byte> span)
		{
			throw null;
		}

		/// <summary>
		/// Reads a string, whose length is determined by a header of one of these types:
		/// <see cref="F:MessagePack.MessagePackCode.Str8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Str32" />,
		/// or a code between <see cref="F:MessagePack.MessagePackCode.MinFixStr" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixStr" />.
		/// </summary>
		/// <returns>A string, or <c>null</c> if the current msgpack token is <see cref="F:MessagePack.MessagePackCode.Nil" />.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ReadString()
		{
			throw null;
		}

		/// <summary>
		/// Reads an extension format header, based on one of these codes:
		/// <see cref="F:MessagePack.MessagePackCode.FixExt1" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt2" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt4" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Ext32" />.
		/// </summary>
		/// <returns>The extension header.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">
		/// Thrown if the header cannot be read in the bytes left in the <see cref="P:MessagePack.MessagePackReader.Sequence" />
		/// or if it is clear that there are insufficient bytes remaining after the header to include all the bytes the header claims to be there.
		/// </exception>
		/// <exception cref="T:MessagePack.MessagePackSerializationException">Thrown if a code other than an extension format header is encountered.</exception>
		public ExtensionHeader ReadExtensionFormatHeader()
		{
			throw null;
		}

		/// <summary>
		/// Reads an extension format header, based on one of these codes:
		/// <see cref="F:MessagePack.MessagePackCode.FixExt1" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt2" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt4" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Ext32" />
		/// if there is sufficient buffer to read it.
		/// </summary>
		/// <param name="extensionHeader">Receives the extension header if the remaining bytes in the <see cref="P:MessagePack.MessagePackReader.Sequence" /> fully describe the header.</param>
		/// <returns>The number of key=value pairs in the map.</returns>
		/// <exception cref="T:MessagePack.MessagePackSerializationException">Thrown if a code other than an extension format header is encountered.</exception>
		/// <remarks>
		/// When this method returns <c>false</c> the position of the reader is left in an undefined position.
		/// The caller is expected to recreate the reader (presumably with a longer sequence to read from) before continuing.
		/// </remarks>
		public bool TryReadExtensionFormatHeader(out ExtensionHeader extensionHeader)
		{
			throw null;
		}

		/// <summary>
		/// Reads an extension format header and data, based on one of these codes:
		/// <see cref="F:MessagePack.MessagePackCode.FixExt1" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt2" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt4" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt8" />,
		/// <see cref="F:MessagePack.MessagePackCode.FixExt16" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext8" />,
		/// <see cref="F:MessagePack.MessagePackCode.Ext16" />, or
		/// <see cref="F:MessagePack.MessagePackCode.Ext32" />.
		/// </summary>
		/// <returns>
		/// The extension format.
		/// The data is a slice from the original sequence passed to this reader's constructor.
		/// </returns>
		public ExtensionResult ReadExtensionFormat()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Byte" /> value from:
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />,
		/// or any of the other MsgPack integer types.
		/// </summary>
		/// <returns>The value.</returns>
		/// <exception cref="T:System.OverflowException">Thrown when the value exceeds what can be stored in the returned type.</exception>
		public byte ReadByte()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.UInt16" /> value from:
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />,
		/// or any of the other MsgPack integer types.
		/// </summary>
		/// <returns>The value.</returns>
		/// <exception cref="T:System.OverflowException">Thrown when the value exceeds what can be stored in the returned type.</exception>
		public ushort ReadUInt16()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.UInt32" /> value from:
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />,
		/// or any of the other MsgPack integer types.
		/// </summary>
		/// <returns>The value.</returns>
		/// <exception cref="T:System.OverflowException">Thrown when the value exceeds what can be stored in the returned type.</exception>
		public uint ReadUInt32()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.UInt64" /> value from:
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />,
		/// or any of the other MsgPack integer types.
		/// </summary>
		/// <returns>The value.</returns>
		/// <exception cref="T:System.OverflowException">Thrown when the value exceeds what can be stored in the returned type.</exception>
		public ulong ReadUInt64()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.SByte" /> value from:
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />,
		/// or any of the other MsgPack integer types.
		/// </summary>
		/// <returns>The value.</returns>
		/// <exception cref="T:System.OverflowException">Thrown when the value exceeds what can be stored in the returned type.</exception>
		public sbyte ReadSByte()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Int16" /> value from:
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />,
		/// or any of the other MsgPack integer types.
		/// </summary>
		/// <returns>The value.</returns>
		/// <exception cref="T:System.OverflowException">Thrown when the value exceeds what can be stored in the returned type.</exception>
		public short ReadInt16()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Int32" /> value from:
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />,
		/// or any of the other MsgPack integer types.
		/// </summary>
		/// <returns>The value.</returns>
		/// <exception cref="T:System.OverflowException">Thrown when the value exceeds what can be stored in the returned type.</exception>
		public int ReadInt32()
		{
			throw null;
		}

		/// <summary>
		/// Reads an <see cref="T:System.Int64" /> value from:
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinNegativeFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxNegativeFixInt" />,
		/// Some value between <see cref="F:MessagePack.MessagePackCode.MinFixInt" /> and <see cref="F:MessagePack.MessagePackCode.MaxFixInt" />,
		/// or any of the other MsgPack integer types.
		/// </summary>
		/// <returns>The value.</returns>
		/// <exception cref="T:System.OverflowException">Thrown when the value exceeds what can be stored in the returned type.</exception>
		public long ReadInt64()
		{
			throw null;
		}
	}
}
