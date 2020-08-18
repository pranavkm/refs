using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal class StartupLoader
	{
		private abstract class ConfigureServicesDelegateBuilder
		{
			public abstract Func<IServiceCollection, IServiceProvider> Build();

			protected ConfigureServicesDelegateBuilder()
			{
				throw null;
			}
		}

		private class ConfigureServicesDelegateBuilder<TContainerBuilder> : ConfigureServicesDelegateBuilder
		{
			public IServiceProvider HostingServiceProvider
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ConfigureServicesBuilder ConfigureServicesBuilder
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ConfigureContainerBuilder ConfigureContainerBuilder
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public object Instance
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ConfigureServicesDelegateBuilder(IServiceProvider hostingServiceProvider, ConfigureServicesBuilder configureServicesBuilder, ConfigureContainerBuilder configureContainerBuilder, object instance)
			{
				throw null;
			}

			public override Func<IServiceCollection, IServiceProvider> Build()
			{
				throw null;
			}
		}

		public static StartupMethods LoadMethods(IServiceProvider hostingServiceProvider, [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type startupType, string environmentName, object instance = null)
		{
			throw null;
		}

		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "We're warning at the entry point. This is an implementation detail.")]
		public static Type FindStartupType(string startupAssemblyName, string environmentName)
		{
			throw null;
		}

		internal static ConfigureBuilder FindConfigureDelegate([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type startupType, string environmentName)
		{
			throw null;
		}

		internal static ConfigureContainerBuilder FindConfigureContainerDelegate([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type startupType, string environmentName)
		{
			throw null;
		}

		internal static bool HasConfigureServicesIServiceProviderDelegate([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type startupType, string environmentName)
		{
			throw null;
		}

		internal static ConfigureServicesBuilder FindConfigureServicesDelegate([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] Type startupType, string environmentName)
		{
			throw null;
		}

		public StartupLoader()
		{
			throw null;
		}
	}
}
