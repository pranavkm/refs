namespace Microsoft.AspNetCore.Cryptography.SafeHandles
{
	internal sealed class BCryptKeyHandle : BCryptHandle
	{
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
