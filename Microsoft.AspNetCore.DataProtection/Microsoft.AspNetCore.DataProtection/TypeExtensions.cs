using System;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Helpful extension methods on <see cref="T:System.Type" />.
	/// </summary>
	internal static class TypeExtensions
	{
		/// <summary>
		/// Throws <see cref="T:System.InvalidCastException" /> if <paramref name="implementationType" />
		/// is not assignable to <paramref name="expectedBaseType" />.
		/// </summary>
		public static void AssertIsAssignableFrom(this Type expectedBaseType, Type implementationType)
		{
			throw null;
		}
	}
}
