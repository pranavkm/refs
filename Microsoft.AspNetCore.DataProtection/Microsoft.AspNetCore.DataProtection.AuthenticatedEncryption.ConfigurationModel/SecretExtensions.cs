using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	internal static class SecretExtensions
	{
		/// <summary>
		/// Converts an <see cref="T:Microsoft.AspNetCore.DataProtection.ISecret" /> to an &lt;masterKey&gt; element which is marked
		/// as requiring encryption.
		/// </summary>
		/// <param name="secret">The secret for accessing the master key.</param>
		/// <returns>The master key <see cref="T:System.Xml.Linq.XElement" />.</returns>
		public static XElement ToMasterKeyElement(this ISecret secret)
		{
			throw null;
		}

		/// <summary>
		/// Converts a base64-encoded string into an <see cref="T:Microsoft.AspNetCore.DataProtection.ISecret" />.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.DataProtection.Secret" />.</returns>
		public static Secret ToSecret(this string base64String)
		{
			throw null;
		}
	}
}
