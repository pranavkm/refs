using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// Represents a configured authenticated encryption mechanism which uses
	/// managed <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> and
	/// <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" /> types.
	/// </summary>
	public sealed class ManagedAuthenticatedEncryptorConfiguration : AlgorithmConfiguration, IInternalAlgorithmConfiguration
	{
		/// <summary>
		/// The type of the algorithm to use for symmetric encryption.
		/// The type must subclass <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" />.
		/// This property is required to have a value.
		/// </summary>
		/// <remarks>
		/// The algorithm must support CBC-style encryption and PKCS#7 padding and must have a block size of 64 bits or greater.
		/// The default algorithm is AES.
		/// </remarks>
		[ApplyPolicy]
		public Type EncryptionAlgorithmType
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
		/// The type of the algorithm to use for validation.
		/// Type type must subclass <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" />.
		/// This property is required to have a value.
		/// </summary>
		/// <remarks>
		/// The algorithm must have a digest length of 128 bits or greater.
		/// The default algorithm is HMACSHA256.
		/// </remarks>
		[ApplyPolicy]
		public Type ValidationAlgorithmType
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
		/// Validates that this <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.ManagedAuthenticatedEncryptorConfiguration" /> is well-formed, i.e.,
		/// that the specified algorithms actually exist and can be instantiated properly.
		/// An exception will be thrown if validation fails.
		/// </summary>
		void IInternalAlgorithmConfiguration.Validate()
		{
			throw null;
		}

		public ManagedAuthenticatedEncryptorConfiguration()
		{
			throw null;
		}
	}
}
