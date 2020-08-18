using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal class HostingApplicationDiagnostics
	{
		public HostingApplicationDiagnostics(ILogger logger, DiagnosticListener diagnosticListener)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void BeginRequest(HttpContext httpContext, HostingApplication.Context context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void RequestEnd(HttpContext httpContext, Exception exception, HostingApplication.Context context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void ContextDisposed(HostingApplication.Context context)
		{
			throw null;
		}
	}
}
