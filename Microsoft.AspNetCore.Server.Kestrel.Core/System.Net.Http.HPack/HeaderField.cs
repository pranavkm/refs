using System.Runtime.CompilerServices;

namespace System.Net.Http.HPack
{
	internal readonly struct HeaderField
	{
		public const int RfcOverhead = 32;

		public byte[] Name
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public byte[] Value
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int Length
		{
			get
			{
				throw null;
			}
		}

		public HeaderField(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public static int GetLength(int nameLength, int valueLength)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
