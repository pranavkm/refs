using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Reflection
{
	internal class MemberAssignment
	{
		private class PropertySetter<TTarget, TValue> : IPropertySetter where TTarget : notnull
		{
			public bool Cascading
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public PropertySetter(MethodInfo setMethod, bool cascading)
			{
				throw null;
			}

			public void SetValue(object target, object value)
			{
				throw null;
			}
		}

		public static IEnumerable<PropertyInfo> GetPropertiesIncludingInherited(Type type, BindingFlags bindingFlags)
		{
			throw null;
		}

		public static IPropertySetter CreatePropertySetter(Type targetType, PropertyInfo property, bool cascading)
		{
			throw null;
		}

		public MemberAssignment()
		{
			throw null;
		}
	}
}
