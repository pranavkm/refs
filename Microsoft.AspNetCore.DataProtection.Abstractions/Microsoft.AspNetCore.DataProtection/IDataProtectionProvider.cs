namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// An interface that can be used to create <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> instances.
	/// </summary>
	public interface IDataProtectionProvider
	{
		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> given a purpose.
		/// </summary>
		/// <param name="purpose">
		/// The purpose to be assigned to the newly-created <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" />.
		/// </param>
		/// <returns>An IDataProtector tied to the provided purpose.</returns>
		/// <remarks>
		/// The <paramref name="purpose" /> parameter must be unique for the intended use case; two
		/// different <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtector" /> instances created with two different <paramref name="purpose" />
		/// values will not be able to decipher each other's payloads. The <paramref name="purpose" /> parameter
		/// value is not intended to be kept secret.
		/// </remarks>
		IDataProtector CreateProtector(string purpose);
	}
}
