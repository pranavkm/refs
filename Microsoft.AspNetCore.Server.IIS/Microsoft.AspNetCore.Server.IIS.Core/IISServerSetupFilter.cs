using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class IISServerSetupFilter : IStartupFilter
	{
		public IISServerSetupFilter(string virtualPath)
		{
			throw null;
		}

		public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
		{
			throw null;
		}
	}
}
