namespace MessagePack
{
	/// <summary>
	/// https://github.com/msgpack/msgpack/blob/master/spec.md#serialization-type-to-format-conversion.
	/// </summary>
	internal enum MessagePackType : byte
	{
		Unknown,
		Integer,
		Nil,
		Boolean,
		Float,
		String,
		Binary,
		Array,
		Map,
		Extension
	}
}
