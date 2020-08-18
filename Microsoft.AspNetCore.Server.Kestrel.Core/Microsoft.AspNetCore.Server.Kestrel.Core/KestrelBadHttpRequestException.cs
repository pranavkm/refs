using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.Extensions.Primitives;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	internal static class KestrelBadHttpRequestException
	{
		[System.Diagnostics.StackTraceHidden]
		internal static void Throw(RequestRejectionReason reason)
		{
			throw null;
		}

		[System.Diagnostics.StackTraceHidden]
		internal static void Throw(RequestRejectionReason reason, HttpMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BadHttpRequestException GetException(RequestRejectionReason reason)
		{
			throw null;
		}

		[System.Diagnostics.StackTraceHidden]
		internal static void Throw(RequestRejectionReason reason, string detail)
		{
			throw null;
		}

		[System.Diagnostics.StackTraceHidden]
		internal static void Throw(RequestRejectionReason reason, StringValues detail)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BadHttpRequestException GetException(RequestRejectionReason reason, string detail)
		{
			throw null;
		}
	}
}
