using System;
using System.IO;
using System.Text;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Utility extensions to streams
	/// </summary>
	internal static class StreamExtensions
	{
		internal static readonly Encoding DefaultEncoding;

		public static BinaryReader CreateReader(this Stream stream)
		{
			throw null;
		}

		public static BinaryWriter CreateWriter(this Stream stream)
		{
			throw null;
		}

		public static DateTimeOffset ReadDateTimeOffset(this BinaryReader reader)
		{
			throw null;
		}

		public static void Write(this BinaryWriter writer, DateTimeOffset value)
		{
			throw null;
		}
	}
}
