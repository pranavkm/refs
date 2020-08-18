using Microsoft.Extensions.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Context for a Hub invocation.
	/// </summary>
	public class HubInvocationContext
	{
		internal ObjectMethodExecutor ObjectMethodExecutor
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the context for the active Hub connection and caller.
		/// </summary>
		public HubCallerContext Context
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the Hub instance.
		/// </summary>
		public Hub Hub
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the name of the Hub method being invoked.
		/// </summary>
		public string HubMethodName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the arguments provided by the client.
		/// </summary>
		public IReadOnlyList<object?> HubMethodArguments
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:System.IServiceProvider" /> specific to the scope of this Hub method invocation.
		/// </summary>
		public IServiceProvider ServiceProvider
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:System.Reflection.MethodInfo" /> for the Hub method being invoked.
		/// </summary>
		public MethodInfo HubMethod
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Instantiates a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubInvocationContext" /> class.
		/// </summary>
		/// <param name="context">Context for the active Hub connection and caller.</param>
		/// <param name="serviceProvider">The <see cref="T:System.IServiceProvider" /> specific to the scope of this Hub method invocation.</param>
		/// <param name="hub">The instance of the Hub.</param>
		/// <param name="hubMethod">The <see cref="T:System.Reflection.MethodInfo" /> for the Hub method being invoked.</param>
		/// <param name="hubMethodArguments">The arguments provided by the client.</param>
		public HubInvocationContext(HubCallerContext context, IServiceProvider serviceProvider, Hub hub, MethodInfo hubMethod, IReadOnlyList<object?> hubMethodArguments)
		{
			throw null;
		}

		/// <summary>
		/// Instantiates a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubInvocationContext" /> class.
		/// </summary>
		/// <param name="context">Context for the active Hub connection and caller.</param>
		/// <param name="hubMethodName">The name of the Hub method being invoked.</param>
		/// <param name="hubMethodArguments">The arguments provided by the client.</param>
		[Obsolete("This constructor is obsolete and will be removed in a future version. The recommended alternative is to use the other constructor.")]
		public HubInvocationContext(HubCallerContext context, string hubMethodName, object?[] hubMethodArguments)
		{
			throw null;
		}

		internal HubInvocationContext(ObjectMethodExecutor objectMethodExecutor, HubCallerContext context, IServiceProvider serviceProvider, Hub hub, object?[] hubMethodArguments)
		{
			throw null;
		}
	}
}
