namespace Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2
{
	/// <summary>
	/// Internal base class used for abstracting away the PBKDF2 implementation since the implementation is OS-specific.
	/// </summary>
	internal static class Pbkdf2Util
	{
		public static readonly IPbkdf2Provider Pbkdf2Provider;
	}
}
