using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
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

		internal StringValues AllowedHeader
		{
			[CompilerGenerated]
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

		internal BadHttpRequestException(string message, int statusCode, RequestRejectionReason reason, HttpMethod? requiredMethod)
		{
			throw null;
		}
	}
}
