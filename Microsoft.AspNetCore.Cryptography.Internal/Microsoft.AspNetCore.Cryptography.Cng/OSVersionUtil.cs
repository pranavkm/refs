namespace Microsoft.AspNetCore.Cryptography.Cng
{
	internal static class OSVersionUtil
	{
		private enum OSVersion
		{
			NotWindows,
			Win7OrLater,
			Win8OrLater
		}

		public static bool IsWindows()
		{
			throw null;
		}

		public static bool IsWindows8OrLater()
		{
			throw null;
		}
	}
}
