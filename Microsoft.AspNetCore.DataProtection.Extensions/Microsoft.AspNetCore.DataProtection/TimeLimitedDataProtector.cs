using System;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Wraps an existing <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> and appends a purpose that allows
	/// protecting data with a finite lifetime.
	/// </summary>
	internal sealed class TimeLimitedDataProtector : ITimeLimitedDataProtector, IDataProtector, IDataProtectionProvider
	{
		public TimeLimitedDataProtector(IDataProtector innerProtector)
		{
			throw null;
		}

		public ITimeLimitedDataProtector CreateProtector(string purpose)
		{
			throw null;
		}

		public byte[] Protect(byte[] plaintext, DateTimeOffset expiration)
		{
			throw null;
		}

		public byte[] Unprotect(byte[] protectedData, out DateTimeOffset expiration)
		{
			throw null;
		}

		internal byte[] UnprotectCore(byte[] protectedData, DateTimeOffset now, out DateTimeOffset expiration)
		{
			throw null;
		}

		IDataProtector IDataProtectionProvider.CreateProtector(string purpose)
		{
			throw null;
		}

		byte[] IDataProtector.Protect(byte[] plaintext)
		{
			throw null;
		}

		byte[] IDataProtector.Unprotect(byte[] protectedData)
		{
			throw null;
		}
	}
}
