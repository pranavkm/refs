using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Diagnostics
{
	public class StatusCodeContext
	{
		public HttpContext HttpContext
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public StatusCodePagesOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RequestDelegate Next
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public StatusCodeContext(HttpContext context, StatusCodePagesOptions options, RequestDelegate next)
		{
			throw null;
		}
	}
}
