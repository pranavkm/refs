using Microsoft.AspNetCore.HttpSys.Internal;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	/// <summary>
	/// Contains helpers for dealing with TLS token binding.
	/// </summary>
	internal static class TokenBindingUtil
	{
		/// <summary>
		/// Returns the 'provided' token binding identifier, optionally also returning the
		/// 'referred' token binding identifier. Returns null on failure.
		/// </summary>
		public unsafe static byte[] GetProvidedTokenIdFromBindingInfo(HttpApiTypes.HTTP_REQUEST_TOKEN_BINDING_INFO* pTokenBindingInfo, out byte[] referredId)
		{
			throw null;
		}
	}
}
