using System;
using System.ComponentModel;

namespace Microsoft.AspNetCore.DataProtection
{
	public static class DataProtectionUtilityExtensions
	{
		/// <summary>
		/// Returns a unique identifier for this application.
		/// </summary>
		/// <param name="services">The application-level <see cref="T:System.IServiceProvider" />.</param>
		/// <returns>A unique application identifier, or null if <paramref name="services" /> is null
		/// or cannot provide a unique application identifier.</returns>
		/// <remarks>
		/// <para>
		/// The returned identifier should be stable for repeated runs of this same application on
		/// this machine. Additionally, the identifier is only unique within the scope of a single
		/// machine, e.g., two different applications on two different machines may return the same
		/// value.
		/// </para>
		/// <para>
		/// This identifier may contain security-sensitive information such as physical file paths,
		/// configuration settings, or other machine-specific information. Callers should take
		/// special care not to disclose this information to untrusted entities.
		/// </para>
		/// </remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string GetApplicationUniqueIdentifier(this IServiceProvider services)
		{
			throw null;
		}
	}
}
