using Microsoft.AspNetCore.DataProtection.Internal;
using System;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Extension methods for working with <see cref="T:Microsoft.AspNetCore.DataProtection.Internal.IActivator" />.
	/// </summary>
	internal static class ActivatorExtensions
	{
		/// <summary>
		/// Creates an instance of <paramref name="implementationTypeName" /> and ensures
		/// that it is assignable to <typeparamref name="T" />.
		/// </summary>
		public static T CreateInstance<T>(this IActivator activator, string implementationTypeName) where T : class
		{
			throw null;
		}

		/// <summary>
		/// Returns a <see cref="T:Microsoft.AspNetCore.DataProtection.Internal.IActivator" /> given an <see cref="T:System.IServiceProvider" />.
		/// Guaranteed to return non-null, even if <paramref name="serviceProvider" /> is null.
		/// </summary>
		public static IActivator GetActivator(this IServiceProvider serviceProvider)
		{
			throw null;
		}
	}
}
