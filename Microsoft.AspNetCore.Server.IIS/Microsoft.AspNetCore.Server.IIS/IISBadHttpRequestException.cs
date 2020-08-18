using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.IIS
{
	internal static class IISBadHttpRequestException
	{
		internal static void Throw(RequestRejectionReason reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BadHttpRequestException GetException(RequestRejectionReason reason)
		{
			throw null;
		}
	}
}
