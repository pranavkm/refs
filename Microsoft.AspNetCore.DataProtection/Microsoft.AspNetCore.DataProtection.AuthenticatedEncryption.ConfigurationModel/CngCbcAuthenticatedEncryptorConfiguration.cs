using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// Represents a configured authenticated encryption mechanism which uses
	/// Windows CNG algorithms in CBC encryption + HMAC authentication modes.
	/// </summary>
	public sealed class CngCbcAuthenticatedEncryptorConfiguration : AlgorithmConfiguration, IInternalAlgorithmConfiguration
	{
		/// <summary>
		/// The name of the algorithm to use for symmetric encryption.
		/// This property corresponds to the 'pszAlgId' parameter of BCryptOpenAlgorithmProvider.
		/// This property is required to have a value.
		/// </summary>
		/// <remarks>
		/// The algorithm must support CBC-style encryption and must have a block size of 64 bits
		/// or greater.
		/// The default value is 'AES'.
		/// </remarks>
		[ApplyPolicy]
		public string EncryptionAlgorithm
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
		/// The name of the provider which contains the implementation of the symmetric encryption algorithm.
		/// This property corresponds to the 'pszImplementation' parameter of BCryptOpenAlgorithmProvider.
		/// This property is optional.
		/// </summary>
		/// <remarks>
		/// The default value is null.
		/// </remarks>
		[ApplyPolicy]
		public string EncryptionAlgorithmProvider
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
		/// The length (in bits) of the key that will be used for symmetric encryption.
		/// This property is required to have a value.
		/// </summary>
		/// <remarks>
		/// The key length must be 128 bits or greater.
		/// The default value is 256.
		/// </remarks>
		[ApplyPolicy]
		public int EncryptionAlgorithmKeySize
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
		/// The name of the algorithm to use for hashing data.
		/// This property corresponds to the 'pszAlgId' parameter of BCryptOpenAlgorithmProvider.
		/// This property is required to have a value.
		/// </summary>
		/// <remarks>
		/// The algorithm must support being opened in HMAC mode and must have a digest length
		/// of 128 bits or greater.
		/// The default value is 'SHA256'.
		/// </remarks>
		[ApplyPolicy]
		public string HashAlgorithm
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
		/// The name of the provider which contains the implementation of the hash algorithm.
		/// This property corresponds to the 'pszImplementation' parameter of BCryptOpenAlgorithmProvider.
		/// This property is optional.
		/// </summary>
		/// <remarks>
		/// The default value is null.
		/// </remarks>
		[ApplyPolicy]
		public string HashAlgorithmProvider
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

		/// <summary>
		/// Validates that this <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngCbcAuthenticatedEncryptorConfiguration" /> is well-formed, i.e.,
		/// that the specified algorithms actually exist and that they can be instantiated properly.
		/// An exception will be thrown if validation fails.
		/// </summary>
		void IInternalAlgorithmConfiguration.Validate()
		{
			throw null;
		}

		public CngCbcAuthenticatedEncryptorConfiguration()
		{
			throw null;
		}
	}
}
