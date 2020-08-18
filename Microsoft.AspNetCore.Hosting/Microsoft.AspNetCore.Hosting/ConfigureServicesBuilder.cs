using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal class ConfigureServicesBuilder
	{
		public MethodInfo MethodInfo
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Func<Func<IServiceCollection, IServiceProvider>, Func<IServiceCollection, IServiceProvider>> StartupServiceFilters
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public ConfigureServicesBuilder(MethodInfo configureServices)
		{
			throw null;
		}

		public Func<IServiceCollection, IServiceProvider> Build(object instance)
		{
			throw null;
		}
	}
}
