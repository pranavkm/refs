namespace Microsoft.AspNetCore.Cryptography.SafeHandles
{
	internal sealed class BCryptHashHandle : BCryptHandle
	{
		/// <summary>
		/// Duplicates this hash handle, including any existing hashed state.
		/// </summary>
		public BCryptHashHandle DuplicateHash()
		{
			throw null;
		}

		/// <summary>
		/// Calculates the cryptographic hash over a set of input data.
		/// </summary>
		public unsafe void HashData(byte* pbInput, uint cbInput, byte* pbHashDigest, uint cbHashDigest)
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}

		internal void SetAlgorithmProviderHandle(BCryptAlgorithmHandle algProviderHandle)
		{
			throw null;
		}
	}
}
