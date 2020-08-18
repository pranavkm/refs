using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Internal
{
	internal class ObjectMethodExecutor
	{
		private delegate ObjectMethodExecutorAwaitable MethodExecutorAsync(object target, object[] parameters);

		private delegate object MethodExecutor(object target, object[] parameters);

		private delegate void VoidMethodExecutor(object target, object[] parameters);

		public MethodInfo MethodInfo
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ParameterInfo[] MethodParameters
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public TypeInfo TargetTypeInfo
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Type AsyncResultType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Type MethodReturnType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public bool IsMethodAsync
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public static ObjectMethodExecutor Create(MethodInfo methodInfo, TypeInfo targetTypeInfo)
		{
			throw null;
		}

		public static ObjectMethodExecutor Create(MethodInfo methodInfo, TypeInfo targetTypeInfo, object[] parameterDefaultValues)
		{
			throw null;
		}

		/// <summary>
		/// Executes the configured method on <paramref name="target" />. This can be used whether or not
		/// the configured method is asynchronous.
		/// </summary>
		/// <remarks>
		/// Even if the target method is asynchronous, it's desirable to invoke it using Execute rather than
		/// ExecuteAsync if you know at compile time what the return type is, because then you can directly
		/// "await" that value (via a cast), and then the generated code will be able to reference the
		/// resulting awaitable as a value-typed variable. If you use ExecuteAsync instead, the generated
		/// code will have to treat the resulting awaitable as a boxed object, because it doesn't know at
		/// compile time what type it would be.
		/// </remarks>
		/// <param name="target">The object whose method is to be executed.</param>
		/// <param name="parameters">Parameters to pass to the method.</param>
		/// <returns>The method return value.</returns>
		public object Execute(object target, object[] parameters)
		{
			throw null;
		}

		/// <summary>
		/// Executes the configured method on <paramref name="target" />. This can only be used if the configured
		/// method is asynchronous.
		/// </summary>
		/// <remarks>
		/// If you don't know at compile time the type of the method's returned awaitable, you can use ExecuteAsync,
		/// which supplies an awaitable-of-object. This always works, but can incur several extra heap allocations
		/// as compared with using Execute and then using "await" on the result value typecasted to the known
		/// awaitable type. The possible extra heap allocations are for:
		///
		/// 1. The custom awaitable (though usually there's a heap allocation for this anyway, since normally
		///    it's a reference type, and you normally create a new instance per call).
		/// 2. The custom awaiter (whether or not it's a value type, since if it's not, you need a new instance
		///    of it, and if it is, it will have to be boxed so the calling code can reference it as an object).
		/// 3. The async result value, if it's a value type (it has to be boxed as an object, since the calling
		///    code doesn't know what type it's going to be).
		/// </remarks>
		/// <param name="target">The object whose method is to be executed.</param>
		/// <param name="parameters">Parameters to pass to the method.</param>
		/// <returns>An object that you can "await" to get the method return value.</returns>
		public ObjectMethodExecutorAwaitable ExecuteAsync(object target, object[] parameters)
		{
			throw null;
		}

		public object GetDefaultValueForParameter(int index)
		{
			throw null;
		}
	}
}
