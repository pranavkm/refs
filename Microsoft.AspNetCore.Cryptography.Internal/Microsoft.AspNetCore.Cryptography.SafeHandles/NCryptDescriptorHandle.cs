using Microsoft.Win32.SafeHandles;

namespace Microsoft.AspNetCore.Cryptography.SafeHandles
{
	internal sealed class NCryptDescriptorHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		public string GetProtectionDescriptorRuleString()
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
