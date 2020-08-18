using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	internal readonly struct CascadingParameterState
	{
		private readonly struct ReflectedCascadingParameterInfo
		{
			public string ConsumerValueName
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public string? SupplierValueName
			{
				[System.Runtime.CompilerServices.NullableContext(2)]
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public Type ValueType
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ReflectedCascadingParameterInfo(string consumerValueName, Type valueType, string? supplierValueName)
			{
				throw null;
			}
		}

		private static readonly ConcurrentDictionary<Type, ReflectedCascadingParameterInfo[]> _cachedInfos;

		public string LocalValueName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ICascadingValueComponent ValueSupplier
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CascadingParameterState(string localValueName, ICascadingValueComponent valueSupplier)
		{
			throw null;
		}

		public static IReadOnlyList<CascadingParameterState> FindCascadingParameters(ComponentState componentState)
		{
			throw null;
		}
	}
}
