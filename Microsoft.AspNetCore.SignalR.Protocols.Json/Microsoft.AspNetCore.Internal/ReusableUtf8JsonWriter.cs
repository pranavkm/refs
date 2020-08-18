using System.Buffers;
using System.Text.Json;

namespace Microsoft.AspNetCore.Internal
{
	internal sealed class ReusableUtf8JsonWriter
	{
		public ReusableUtf8JsonWriter(IBufferWriter<byte> stream)
		{
			throw null;
		}

		public static ReusableUtf8JsonWriter Get(IBufferWriter<byte> stream)
		{
			throw null;
		}

		public static void Return(ReusableUtf8JsonWriter writer)
		{
			throw null;
		}

		public Utf8JsonWriter GetJsonWriter()
		{
			throw null;
		}
	}
}
