using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Helpful extension methods for data protection APIs.
	/// </summary>
	public static class DataProtectionCommonExtensions
	{
		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> given a list of purposes.
		/// </summary>
		/// <param name="provider">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" /> from which to generate the purpose chain.</param>
		/// <param name="purposes">The list of purposes which contribute to the purpose chain. This list must
		/// contain at least one element, and it may not contain null elements.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> tied to the provided purpose chain.</returns>
		/// <remarks>
		/// This is a convenience method which chains together several calls to
		/// <see cref="M:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider.CreateProtector(System.String)" />. See that method's
		/// documentation for more information.
		/// </remarks>
		public static IDataProtector CreateProtector(this IDataProtectionProvider provider, IEnumerable<string> purposes)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> given a list of purposes.
		/// </summary>
		/// <param name="provider">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" /> from which to generate the purpose chain.</param>
		/// <param name="purpose">The primary purpose used to create the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" />.</param>
		/// <param name="subPurposes">An optional list of secondary purposes which contribute to the purpose chain.
		/// If this list is provided it cannot contain null elements.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> tied to the provided purpose chain.</returns>
		/// <remarks>
		/// This is a convenience method which chains together several calls to
		/// <see cref="M:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider.CreateProtector(System.String)" />. See that method's
		/// documentation for more information.
		/// </remarks>
		public static IDataProtector CreateProtector(this IDataProtectionProvider provider, string purpose, params string[] subPurposes)
		{
			throw null;
		}

		/// <summary>
		/// Retrieves an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" /> from an <see cref="T:System.IServiceProvider" />.
		/// </summary>
		/// <param name="services">The service provider from which to retrieve the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" />.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" />. This method is guaranteed never to return null.</returns>
		/// <exception cref="T:System.InvalidOperationException">If no <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" /> service exists in <paramref name="services" />.</exception>
		public static IDataProtectionProvider GetDataProtectionProvider(this IServiceProvider services)
		{
			throw null;
		}

		/// <summary>
		/// Retrieves an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> from an <see cref="T:System.IServiceProvider" /> given a list of purposes.
		/// </summary>
		/// <param name="services">An <see cref="T:System.IServiceProvider" /> which contains the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" />
		/// from which to generate the purpose chain.</param>
		/// <param name="purposes">The list of purposes which contribute to the purpose chain. This list must
		/// contain at least one element, and it may not contain null elements.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> tied to the provided purpose chain.</returns>
		/// <remarks>
		/// This is a convenience method which calls <see cref="M:Microsoft.AspNetCore.DataProtection.DataProtectionCommonExtensions.GetDataProtectionProvider(System.IServiceProvider)" />
		/// then <see cref="M:Microsoft.AspNetCore.DataProtection.DataProtectionCommonExtensions.CreateProtector(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider,System.Collections.Generic.IEnumerable{System.String})" />. See those methods'
		/// documentation for more information.
		/// </remarks>
		public static IDataProtector GetDataProtector(this IServiceProvider services, IEnumerable<string> purposes)
		{
			throw null;
		}

		/// <summary>
		/// Retrieves an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> from an <see cref="T:System.IServiceProvider" /> given a list of purposes.
		/// </summary>
		/// <param name="services">An <see cref="T:System.IServiceProvider" /> which contains the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" />
		/// from which to generate the purpose chain.</param>
		/// <param name="purpose">The primary purpose used to create the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" />.</param>
		/// <param name="subPurposes">An optional list of secondary purposes which contribute to the purpose chain.
		/// If this list is provided it cannot contain null elements.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> tied to the provided purpose chain.</returns>
		/// <remarks>
		/// This is a convenience method which calls <see cref="M:Microsoft.AspNetCore.DataProtection.DataProtectionCommonExtensions.GetDataProtectionProvider(System.IServiceProvider)" />
		/// then <see cref="M:Microsoft.AspNetCore.DataProtection.DataProtectionCommonExtensions.CreateProtector(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider,System.String,System.String[])" />. See those methods'
		/// documentation for more information.
		/// </remarks>
		public static IDataProtector GetDataProtector(this IServiceProvider services, string purpose, params string[] subPurposes)
		{
			throw null;
		}

		/// <summary>
		/// Cryptographically protects a piece of plaintext data.
		/// </summary>
		/// <param name="protector">The data protector to use for this operation.</param>
		/// <param name="plaintext">The plaintext data to protect.</param>
		/// <returns>The protected form of the plaintext data.</returns>
		public static string Protect(this IDataProtector protector, string plaintext)
		{
			throw null;
		}

		/// <summary>
		/// Cryptographically unprotects a piece of protected data.
		/// </summary>
		/// <param name="protector">The data protector to use for this operation.</param>
		/// <param name="protectedData">The protected data to unprotect.</param>
		/// <returns>The plaintext form of the protected data.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		/// Thrown if <paramref name="protectedData" /> is invalid or malformed.
		/// </exception>
		public static string Unprotect(this IDataProtector protector, string protectedData)
		{
			throw null;
		}
	}
}
