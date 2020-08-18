using System;
using System.Linq.Expressions;

namespace Microsoft.Extensions.Internal
{
	/// <summary>
	/// Helper for detecting whether a given type is FSharpAsync`1, and if so, supplying
	/// an <see cref="T:System.Linq.Expressions.Expression" /> for mapping instances of that type to a C# awaitable.
	/// </summary>
	/// <remarks>
	/// The main design goal here is to avoid taking a compile-time dependency on
	/// FSharp.Core.dll, because non-F# applications wouldn't use it. So all the references
	/// to FSharp types have to be constructed dynamically at runtime.
	/// </remarks>
	internal static class ObjectMethodExecutorFSharpSupport
	{
		public static bool TryBuildCoercerFromFSharpAsyncToAwaitable(Type possibleFSharpAsyncType, out Expression coerceToAwaitableExpression, out Type awaitableType)
		{
			throw null;
		}
	}
}
