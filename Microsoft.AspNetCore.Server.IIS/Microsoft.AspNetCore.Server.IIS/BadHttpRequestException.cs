using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.IIS
{
	[Obsolete("Moved to Microsoft.AspNetCore.Http.BadHttpRequestException")]
	public sealed class BadHttpRequestException : Microsoft.AspNetCore.Http.BadHttpRequestException
	{
		public new int StatusCode
		{
			get
			{
				throw null;
			}
		}

		internal RequestRejectionReason Reason
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal BadHttpRequestException(string message, int statusCode, RequestRejectionReason reason)
		{
			throw null;
		}
	}
}
