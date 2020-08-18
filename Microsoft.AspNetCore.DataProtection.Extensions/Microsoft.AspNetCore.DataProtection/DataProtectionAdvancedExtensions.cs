using System;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Helpful extension methods for data protection APIs.
	/// </summary>
	public static class DataProtectionAdvancedExtensions
	{
		private sealed class TimeLimitedWrappingProtector : IDataProtector, IDataProtectionProvider
		{
			public DateTimeOffset Expiration;

			public TimeLimitedWrappingProtector(ITimeLimitedDataProtector innerProtector)
			{
				throw null;
			}

			public IDataProtector CreateProtector(string purpose)
			{
				throw null;
			}

			public byte[] Protect(byte[] plaintext)
			{
				throw null;
			}

			public byte[] Unprotect(byte[] protectedData)
			{
				throw null;
			}
		}

		/// <summary>
		/// Cryptographically protects a piece of plaintext data, expiring the data after
		/// the specified amount of time has elapsed.
		/// </summary>
		/// <param name="protector">The protector to use.</param>
		/// <param name="plaintext">The plaintext data to protect.</param>
		/// <param name="lifetime">The amount of time after which the payload should no longer be unprotectable.</param>
		/// <returns>The protected form of the plaintext data.</returns>
		public static byte[] Protect(this ITimeLimitedDataProtector protector, byte[] plaintext, TimeSpan lifetime)
		{
			throw null;
		}

		/// <summary>
		/// Cryptographically protects a piece of plaintext data, expiring the data at
		/// the chosen time.
		/// </summary>
		/// <param name="protector">The protector to use.</param>
		/// <param name="plaintext">The plaintext data to protect.</param>
		/// <param name="expiration">The time when this payload should expire.</param>
		/// <returns>The protected form of the plaintext data.</returns>
		public static string Protect(this ITimeLimitedDataProtector protector, string plaintext, DateTimeOffset expiration)
		{
			throw null;
		}

		/// <summary>
		/// Cryptographically protects a piece of plaintext data, expiring the data after
		/// the specified amount of time has elapsed.
		/// </summary>
		/// <param name="protector">The protector to use.</param>
		/// <param name="plaintext">The plaintext data to protect.</param>
		/// <param name="lifetime">The amount of time after which the payload should no longer be unprotectable.</param>
		/// <returns>The protected form of the plaintext data.</returns>
		public static string Protect(this ITimeLimitedDataProtector protector, string plaintext, TimeSpan lifetime)
		{
			throw null;
		}

		/// <summary>
		/// Converts an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> into an <see cref="T:Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector" />
		/// so that payloads can be protected with a finite lifetime.
		/// </summary>
		/// <param name="protector">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> to convert to a time-limited protector.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector" />.</returns>
		public static ITimeLimitedDataProtector ToTimeLimitedDataProtector(this IDataProtector protector)
		{
			throw null;
		}

		/// <summary>
		/// Cryptographically unprotects a piece of protected data.
		/// </summary>
		/// <param name="protector">The protector to use.</param>
		/// <param name="protectedData">The protected data to unprotect.</param>
		/// <param name="expiration">An 'out' parameter which upon a successful unprotect
		/// operation receives the expiration date of the payload.</param>
		/// <returns>The plaintext form of the protected data.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		/// Thrown if <paramref name="protectedData" /> is invalid, malformed, or expired.
		/// </exception>
		public static string Unprotect(this ITimeLimitedDataProtector protector, string protectedData, out DateTimeOffset expiration)
		{
			throw null;
		}
	}
}
