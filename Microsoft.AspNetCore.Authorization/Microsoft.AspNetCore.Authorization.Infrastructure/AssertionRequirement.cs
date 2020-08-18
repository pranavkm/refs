using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization.Infrastructure
{
	/// <summary>
	/// Implements an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" /> and <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />
	/// that takes a user specified assertion.
	/// </summary>
	public class AssertionRequirement : IAuthorizationHandler, IAuthorizationRequirement
	{
		/// <summary>
		/// Function that is called to handle this requirement.
		/// </summary>
		public Func<AuthorizationHandlerContext, Task<bool>> Handler
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement" />.
		/// </summary>
		/// <param name="handler">Function that is called to handle this requirement.</param>
		public AssertionRequirement(Func<AuthorizationHandlerContext, bool> handler)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement" />.
		/// </summary>
		/// <param name="handler">Function that is called to handle this requirement.</param>
		public AssertionRequirement(Func<AuthorizationHandlerContext, Task<bool>> handler)
		{
			throw null;
		}

		/// <summary>
		/// Calls <see cref="P:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement.Handler" /> to see if authorization is allowed.
		/// </summary>
		/// <param name="context">The authorization information.</param>
		[AsyncStateMachine(typeof(_003CHandleAsync_003Ed__5))]
		[DebuggerStepThrough]
		public Task HandleAsync(AuthorizationHandlerContext context)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
