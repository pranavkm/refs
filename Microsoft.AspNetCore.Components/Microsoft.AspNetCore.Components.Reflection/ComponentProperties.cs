using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Reflection
{
	internal static class ComponentProperties
	{
		private class WritersForType
		{
			public IPropertySetter? CaptureUnmatchedValuesWriter
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public string? CaptureUnmatchedValuesPropertyName
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			[System.Runtime.CompilerServices.NullableContext(1)]
			public WritersForType(Type targetType)
			{
				throw null;
			}

			public bool TryGetValue(string parameterName, [MaybeNullWhen(false)] out IPropertySetter writer)
			{
				throw null;
			}
		}

		public static void SetProperties(in ParameterView parameters, object target)
		{
			throw null;
		}

		internal static IEnumerable<PropertyInfo> GetCandidateBindableProperties(Type targetType)
		{
			throw null;
		}
	}
}
