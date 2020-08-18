using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Provides the APIs for managing user in a persistence store.
	/// </summary>
	/// <typeparam name="TUser">The type encapsulating a user.</typeparam>
	public class AspNetUserManager<TUser> : UserManager<TUser>, IDisposable where TUser : class
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
		/// Constructs a new instance of <see cref="T:Microsoft.AspNetCore.Identity.AspNetUserManager`1" />.
		/// </summary>
		/// <param name="store">The persistence store the manager will operate over.</param>
		/// <param name="optionsAccessor">The accessor used to access the <see cref="T:Microsoft.AspNetCore.Identity.IdentityOptions" />.</param>
		/// <param name="passwordHasher">The password hashing implementation to use when saving passwords.</param>
		/// <param name="userValidators">A collection of <see cref="T:Microsoft.AspNetCore.Identity.IUserValidator`1" /> to validate users against.</param>
		/// <param name="passwordValidators">A collection of <see cref="T:Microsoft.AspNetCore.Identity.IPasswordValidator`1" /> to validate passwords against.</param>
		/// <param name="keyNormalizer">The <see cref="T:Microsoft.AspNetCore.Identity.ILookupNormalizer" /> to use when generating index keys for users.</param>
		/// <param name="errors">The <see cref="T:Microsoft.AspNetCore.Identity.IdentityErrorDescriber" /> used to provider error messages.</param>
		/// <param name="services">The <see cref="T:System.IServiceProvider" /> used to resolve services.</param>
		/// <param name="logger">The logger used to log messages, warnings and errors.</param>
		public AspNetUserManager(IUserStore<TUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<TUser> passwordHasher, IEnumerable<IUserValidator<TUser>> userValidators, IEnumerable<IPasswordValidator<TUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<TUser>> logger)
		{
			throw null;
		}
	}
}
