using System;
using System.Runtime.CompilerServices;

namespace MessagePack
{
	internal struct ExtensionHeader : IEquatable<ExtensionHeader>
	{
		public sbyte TypeCode
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public uint Length
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public ExtensionHeader(sbyte typeCode, uint length)
		{
			throw null;
		}

		public ExtensionHeader(sbyte typeCode, int length)
		{
			throw null;
		}

		public bool Equals(ExtensionHeader other)
		{
			throw null;
		}
	}
}
