using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// Represents a generalized authenticated encryption mechanism.
	/// </summary>
	public sealed class AuthenticatedEncryptorConfiguration : AlgorithmConfiguration, IInternalAlgorithmConfiguration
	{
		/// <summary>
		/// The algorithm to use for symmetric encryption (confidentiality).
		/// </summary>
		/// <remarks>
		/// The default value is <see cref="F:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.EncryptionAlgorithm.AES_256_CBC" />.
		/// </remarks>
		public EncryptionAlgorithm EncryptionAlgorithm
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// The algorithm to use for message authentication (tamper-proofing).
		/// </summary>
		/// <remarks>
		/// The default value is <see cref="F:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ValidationAlgorithm.HMACSHA256" />.
		/// This property is ignored if <see cref="P:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AuthenticatedEncryptorConfiguration.EncryptionAlgorithm" /> specifies a 'GCM' algorithm.
		/// </remarks>
		public ValidationAlgorithm ValidationAlgorithm
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public override IAuthenticatedEncryptorDescriptor CreateNewDescriptor()
		{
			throw null;
		}

		IAuthenticatedEncryptorDescriptor IInternalAlgorithmConfiguration.CreateDescriptorFromSecret(ISecret secret)
		{
			throw null;
		}

		void IInternalAlgorithmConfiguration.Validate()
		{
			throw null;
		}

		public AuthenticatedEncryptorConfiguration()
		{
			throw null;
		}
	}
}
