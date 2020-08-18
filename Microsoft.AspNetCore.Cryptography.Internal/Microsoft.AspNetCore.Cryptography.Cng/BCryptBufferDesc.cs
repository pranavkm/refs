using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cryptography.Cng
{
	internal struct BCryptBufferDesc
	{
		private const int BCRYPTBUFFER_VERSION = 0;

		public uint ulVersion;

		public uint cBuffers;

		public unsafe BCryptBuffer* pBuffers;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Initialize(ref BCryptBufferDesc bufferDesc)
		{
			throw null;
		}
	}
}
