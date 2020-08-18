namespace Microsoft.AspNetCore.Cryptography.Cng
{
	/// <summary>
	/// Wraps utility BCRYPT APIs that don't work directly with handles.
	/// </summary>
	internal static class BCryptUtil
	{
		/// <summary>
		/// Fills a buffer with cryptographically secure random data.
		/// </summary>
		public unsafe static void GenRandom(byte* pbBuffer, uint cbBuffer)
		{
			throw null;
		}
	}
}
