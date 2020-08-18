using System;
using System.Diagnostics;

namespace Microsoft.AspNetCore.Antiforgery
{
	[DebuggerDisplay("{DebuggerString}")]
	internal sealed class BinaryBlob : IEquatable<BinaryBlob>
	{
		public int BitLength
		{
			get
			{
				throw null;
			}
		}

		public BinaryBlob(int bitLength)
		{
			throw null;
		}

		public BinaryBlob(int bitLength, byte[] data)
		{
			throw null;
		}

		public override bool Equals(object? obj)
		{
			throw null;
		}

		public bool Equals(BinaryBlob? other)
		{
			throw null;
		}

		public byte[] GetData()
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}
	}
}
