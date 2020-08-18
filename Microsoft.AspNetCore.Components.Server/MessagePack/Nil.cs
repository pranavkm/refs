using System;
using System.Runtime.InteropServices;

namespace MessagePack
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct Nil : IEquatable<Nil>
	{
		public static readonly Nil Default;

		public override bool Equals(object obj)
		{
			throw null;
		}

		public bool Equals(Nil other)
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
