using Microsoft.Win32.SafeHandles;

namespace Microsoft.AspNetCore.Cryptography.SafeHandles
{
	internal abstract class BCryptHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		protected BCryptHandle()
		{
			throw null;
		}

		protected unsafe uint GetProperty(string pszProperty, void* pbOutput, uint cbOutput)
		{
			throw null;
		}

		protected unsafe void SetProperty(string pszProperty, void* pbInput, uint cbInput)
		{
			throw null;
		}
	}
}
