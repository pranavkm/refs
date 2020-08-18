using Microsoft.AspNetCore.Builder;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Hosting
{
	internal interface ISupportsStartup
	{
		IWebHostBuilder Configure(Action<WebHostBuilderContext, IApplicationBuilder> configure);

		IWebHostBuilder UseStartup([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type startupType);

		IWebHostBuilder UseStartup<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TStartup>(Func<WebHostBuilderContext, TStartup> startupFactory);
	}
}
