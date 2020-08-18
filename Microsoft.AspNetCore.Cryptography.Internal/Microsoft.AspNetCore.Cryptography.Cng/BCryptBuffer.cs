using System;

namespace Microsoft.AspNetCore.Cryptography.Cng
{
	internal struct BCryptBuffer
	{
		public uint cbBuffer;

		public BCryptKeyDerivationBufferType BufferType;

		public IntPtr pvBuffer;
	}
}
