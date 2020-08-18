using Microsoft.AspNetCore.Cryptography.SafeHandles;

namespace Microsoft.AspNetCore.DataProtection.Cng
{
	internal static class DpapiSecretSerializerHelper
	{
		public static bool CanProtectToCurrentUserAccount()
		{
			throw null;
		}

		public static byte[] ProtectWithDpapi(ISecret secret, bool protectToLocalMachine = false)
		{
			throw null;
		}

		internal unsafe static byte[] ProtectWithDpapiCore(byte* pbSecret, uint cbSecret, byte* pbOptionalEntropy, uint cbOptionalEntropy, bool fLocalMachine = false)
		{
			throw null;
		}

		public static byte[] ProtectWithDpapiNG(ISecret secret, NCryptDescriptorHandle protectionDescriptorHandle)
		{
			throw null;
		}

		public static Secret UnprotectWithDpapi(byte[] protectedSecret)
		{
			throw null;
		}

		internal unsafe static Secret UnprotectWithDpapiCore(byte* pbProtectedData, uint cbProtectedData, byte* pbOptionalEntropy, uint cbOptionalEntropy)
		{
			throw null;
		}

		public static Secret UnprotectWithDpapiNG(byte[] protectedData)
		{
			throw null;
		}

		public static string GetRuleFromDpapiNGProtectedPayload(byte[] protectedData)
		{
			throw null;
		}
	}
}
