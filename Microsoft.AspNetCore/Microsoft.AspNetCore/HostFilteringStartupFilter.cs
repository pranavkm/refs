using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Microsoft.AspNetCore
{
	internal class HostFilteringStartupFilter : IStartupFilter
	{
		public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
		{
			throw null;
		}

		public HostFilteringStartupFilter()
		{
			throw null;
		}
	}
}
