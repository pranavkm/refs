using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	public readonly struct TargetOffsetPathLength
	{
		private readonly ulong _targetOffsetPathLength;

		public int Offset
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		public int Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsEncoded
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TargetOffsetPathLength(int offset, int length, bool isEncoded)
		{
			throw null;
		}
	}
}
