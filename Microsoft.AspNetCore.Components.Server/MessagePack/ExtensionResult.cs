using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace MessagePack
{
	internal struct ExtensionResult
	{
		public sbyte TypeCode
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public ReadOnlySequence<byte> Data
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		public ExtensionHeader Header
		{
			get
			{
				throw null;
			}
		}

		public ExtensionResult(sbyte typeCode, Memory<byte> data)
		{
			throw null;
		}

		public ExtensionResult(sbyte typeCode, ReadOnlySequence<byte> data)
		{
			throw null;
		}
	}
}
