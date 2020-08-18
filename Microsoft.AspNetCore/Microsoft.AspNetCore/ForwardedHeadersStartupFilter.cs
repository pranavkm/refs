using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Microsoft.AspNetCore
{
	internal class ForwardedHeadersStartupFilter : IStartupFilter
	{
		public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
		{
			throw null;
		}

		public ForwardedHeadersStartupFilter()
		{
			throw null;
		}
	}
}
