using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;

namespace Microsoft.AspNetCore.Server.IISIntegration
{
	internal class IISSetupFilter : IStartupFilter
	{
		internal IISSetupFilter(string pairingToken, PathString pathBase, bool isWebsocketsSupported)
		{
			throw null;
		}

		public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
		{
			throw null;
		}
	}
}
