using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Microsoft.JSInterop.Infrastructure
{
	/// <summary>
	/// Provides methods that receive incoming calls from JS to .NET.
	/// </summary>
	public static class DotNetDispatcher
	{
		private readonly struct AssemblyKey : IEquatable<AssemblyKey>
		{
			public Assembly? Assembly
			{
				[System.Runtime.CompilerServices.NullableContext(2)]
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public string AssemblyName
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public AssemblyKey(Assembly assembly)
			{
				throw null;
			}

			public AssemblyKey(string assemblyName)
			{
				throw null;
			}

			public bool Equals(AssemblyKey other)
			{
				throw null;
			}

			public override int GetHashCode()
			{
				throw null;
			}
		}

		internal static readonly JsonEncodedText DotNetObjectRefKey;

		/// <summary>
		/// Receives a call from JS to .NET, locating and invoking the specified method.
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.JSRuntime" />.</param>
		/// <param name="invocationInfo">The <see cref="T:Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo" />.</param>
		/// <param name="argsJson">A JSON representation of the parameters.</param>
		/// <returns>A JSON representation of the return value, or null.</returns>
		public static string? Invoke(JSRuntime jsRuntime, in DotNetInvocationInfo invocationInfo, string argsJson)
		{
			throw null;
		}

		/// <summary>
		/// Receives a call from JS to .NET, locating and invoking the specified method asynchronously.
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.JSRuntime" />.</param>
		/// <param name="invocationInfo">The <see cref="T:Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo" />.</param>
		/// <param name="argsJson">A JSON representation of the parameters.</param>
		/// <returns>A JSON representation of the return value, or null.</returns>
		public static void BeginInvokeDotNet(JSRuntime jsRuntime, DotNetInvocationInfo invocationInfo, string argsJson)
		{
			throw null;
		}

		internal static object?[] ParseArguments(JSRuntime jsRuntime, string methodIdentifier, string arguments, Type[] parameterTypes)
		{
			throw null;
		}

		/// <summary>
		/// Receives notification that a call from .NET to JS has finished, marking the
		/// associated <see cref="T:System.Threading.Tasks.Task" /> as completed.
		/// </summary>
		/// <remarks>
		/// All exceptions from <see cref="M:Microsoft.JSInterop.Infrastructure.DotNetDispatcher.EndInvokeJS(Microsoft.JSInterop.JSRuntime,System.String)" /> are caught
		/// are delivered via JS interop to the JavaScript side when it requests confirmation, as
		/// the mechanism to call <see cref="M:Microsoft.JSInterop.Infrastructure.DotNetDispatcher.EndInvokeJS(Microsoft.JSInterop.JSRuntime,System.String)" /> relies on
		/// using JS-&gt;.NET interop. This overload is meant for directly triggering completion callbacks
		/// for .NET -&gt; JS operations without going through JS interop, so the callsite for this
		/// method is responsible for handling any possible exception generated from the arguments
		/// passed in as parameters.
		/// </remarks>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.JSRuntime" />.</param>
		/// <param name="arguments">The serialized arguments for the callback completion.</param>
		/// <exception cref="T:System.Exception">
		/// This method can throw any exception either from the argument received or as a result
		/// of executing any callback synchronously upon completion.
		/// </exception>
		public static void EndInvokeJS(JSRuntime jsRuntime, string arguments)
		{
			throw null;
		}
	}
}
