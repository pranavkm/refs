using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Provides the APIs for managing roles in a persistence store.
	/// </summary>
	/// <typeparam name="TRole">The type encapsulating a role.</typeparam>
	public class AspNetRoleManager<TRole> : RoleManager<TRole>, IDisposable where TRole : class
	{
		/// <summary>
		/// The cancellation token associated with the current HttpContext.RequestAborted or CancellationToken.None if unavailable.
		/// </summary>
		protected override CancellationToken CancellationToken
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs a new instance of <see cref="T:Microsoft.AspNetCore.Identity.RoleManager`1" />.
		/// </summary>
		/// <param name="store">The persistence store the manager will operate over.</param>
		/// <param name="roleValidators">A collection of validators for roles.</param>
		/// <param name="keyNormalizer">The normalizer to use when normalizing role names to keys.</param>
		/// <param name="errors">The <see cref="T:Microsoft.AspNetCore.Identity.IdentityErrorDescriber" /> used to provider error messages.</param>
		/// <param name="logger">The logger used to log messages, warnings and errors.</param>
		/// <param name="contextAccessor">The accessor used to access the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		public AspNetRoleManager(IRoleStore<TRole> store, IEnumerable<IRoleValidator<TRole>> roleValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, ILogger<RoleManager<TRole>> logger, IHttpContextAccessor contextAccessor)
		{
			throw null;
		}
	}
}
