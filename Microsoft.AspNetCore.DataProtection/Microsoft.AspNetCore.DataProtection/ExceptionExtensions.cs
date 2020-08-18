using System;

namespace Microsoft.AspNetCore.DataProtection
{
	internal static class ExceptionExtensions
	{
		/// <summary>
		/// Determines whether an exception must be homogenized by being wrapped inside a
		/// CryptographicException before being rethrown.
		/// </summary>
		public static bool RequiresHomogenization(this Exception ex)
		{
			throw null;
		}
	}
}
