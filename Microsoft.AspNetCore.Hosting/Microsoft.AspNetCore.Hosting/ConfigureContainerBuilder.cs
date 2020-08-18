using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Hosting
{
	internal class ConfigureContainerBuilder
	{
		public MethodInfo MethodInfo
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Func<Action<object>, Action<object>> ConfigureContainerFilters
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

		public ConfigureContainerBuilder(MethodInfo configureContainerMethod)
		{
			throw null;
		}

		public Action<object> Build(object instance)
		{
			throw null;
		}

		public Type GetContainerType()
		{
			throw null;
		}
	}
}
