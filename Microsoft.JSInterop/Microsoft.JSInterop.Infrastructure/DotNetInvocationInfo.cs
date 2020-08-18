using System.Runtime.CompilerServices;

namespace Microsoft.JSInterop.Infrastructure
{
	/// <summary>
	/// Information about a JSInterop call from JavaScript to .NET.
	/// </summary>
	public readonly struct DotNetInvocationInfo
	{
		/// <summary>
		/// Gets the name of the assembly containing the method.
		/// Only one of <see cref="P:Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo.DotNetObjectId" /> or <see cref="P:Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo.AssemblyName" /> may be specified.
		/// </summary>
		public string AssemblyName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the identifier of the method to be invoked. This is the value specified in the <see cref="T:Microsoft.JSInterop.JSInvokableAttribute" />.
		/// </summary>
		public string MethodIdentifier
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the object identifier for instance method calls.
		/// Only one of <see cref="P:Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo.DotNetObjectId" /> or <see cref="P:Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo.AssemblyName" /> may be specified.
		/// </summary>
		public long DotNetObjectId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the call identifier. This value is <see langword="null" /> when the client does not expect a value to be returned.
		/// </summary>
		public string CallId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.JSInterop.Infrastructure.DotNetInvocationInfo" />.
		/// </summary>
		/// <param name="assemblyName">The name of the assembly containing the method.</param>
		/// <param name="methodIdentifier">The identifier of the method to be invoked.</param>
		/// <param name="dotNetObjectId">The object identifier for instance method calls.</param>
		/// <param name="callId">The call identifier.</param>
		public DotNetInvocationInfo(string assemblyName, string methodIdentifier, long dotNetObjectId, string callId)
		{
			throw null;
		}
	}
}
