using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Hosting
{
	internal interface ISupportsUseDefaultServiceProvider
	{
		IWebHostBuilder UseDefaultServiceProvider(Action<WebHostBuilderContext, ServiceProviderOptions> configure);
	}
}
