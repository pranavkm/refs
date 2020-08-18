using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal class StartupMethods
	{
		public object StartupInstance
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Func<IServiceCollection, IServiceProvider> ConfigureServicesDelegate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Action<IApplicationBuilder> ConfigureDelegate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public StartupMethods(object instance, Action<IApplicationBuilder> configure, Func<IServiceCollection, IServiceProvider> configureServices)
		{
			throw null;
		}
	}
}
