using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Internal
{
	internal readonly struct AwaitableInfo
	{
		public Type AwaiterType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public PropertyInfo AwaiterIsCompletedProperty
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public MethodInfo AwaiterGetResultMethod
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public MethodInfo AwaiterOnCompletedMethod
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public MethodInfo AwaiterUnsafeOnCompletedMethod
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Type ResultType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public MethodInfo GetAwaiterMethod
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public AwaitableInfo(Type awaiterType, PropertyInfo awaiterIsCompletedProperty, MethodInfo awaiterGetResultMethod, MethodInfo awaiterOnCompletedMethod, MethodInfo awaiterUnsafeOnCompletedMethod, Type resultType, MethodInfo getAwaiterMethod)
		{
			throw null;
		}

		public static bool IsTypeAwaitable(Type type, out AwaitableInfo awaitableInfo)
		{
			throw null;
		}
	}
}
