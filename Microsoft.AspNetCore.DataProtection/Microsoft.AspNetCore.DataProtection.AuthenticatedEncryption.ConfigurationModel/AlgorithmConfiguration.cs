namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	public abstract class AlgorithmConfiguration
	{
		internal const int KDK_SIZE_IN_BYTES = 64;

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" /> instance based on this
		/// configuration. The newly-created instance contains unique key material and is distinct
		/// from all other descriptors created by the <see cref="M:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration.CreateNewDescriptor" /> method.
		/// </summary>
		/// <returns>A unique <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" />.</returns>
		public abstract IAuthenticatedEncryptorDescriptor CreateNewDescriptor();

		protected AlgorithmConfiguration()
		{
			throw null;
		}
	}
}
