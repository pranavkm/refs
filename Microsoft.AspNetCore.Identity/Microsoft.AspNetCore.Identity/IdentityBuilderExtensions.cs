namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Helper functions for configuring identity services.
	/// </summary>
	public static class IdentityBuilderExtensions
	{
		/// <summary>
		/// Adds the default token providers used to generate tokens for reset passwords, change email
		/// and change telephone number operations, and for two factor authentication token generation.
		/// </summary>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Identity.IdentityBuilder" /> instance.</param>
		/// <returns>The current <see cref="T:Microsoft.AspNetCore.Identity.IdentityBuilder" /> instance.</returns>
		public static IdentityBuilder AddDefaultTokenProviders(this IdentityBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Identity.SignInManager`1" /> for the <see cref="P:Microsoft.AspNetCore.Identity.IdentityBuilder.UserType" />.
		/// </summary>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Identity.IdentityBuilder" /> instance.</param>
		/// <returns>The current <see cref="T:Microsoft.AspNetCore.Identity.IdentityBuilder" /> instance.</returns>
		public static IdentityBuilder AddSignInManager(this IdentityBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Identity.SignInManager`1" /> for the <see cref="P:Microsoft.AspNetCore.Identity.IdentityBuilder.UserType" />.
		/// </summary>
		/// <typeparam name="TSignInManager">The type of the sign in manager to add.</typeparam>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Identity.IdentityBuilder" /> instance.</param>
		/// <returns>The current <see cref="T:Microsoft.AspNetCore.Identity.IdentityBuilder" /> instance.</returns>
		public static IdentityBuilder AddSignInManager<TSignInManager>(this IdentityBuilder builder) where TSignInManager : class
		{
			throw null;
		}
	}
}
