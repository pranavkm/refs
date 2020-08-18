using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Extensions for configuring data protection using an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.
	/// </summary>
	public static class DataProtectionBuilderExtensions
	{
		/// <summary>
		/// Sets the unique name of this application within the data protection system.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="applicationName">The application name.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// This API corresponds to setting the <see cref="P:Microsoft.AspNetCore.DataProtection.DataProtectionOptions.ApplicationDiscriminator" /> property
		/// to the value of <paramref name="applicationName" />.
		/// </remarks>
		public static IDataProtectionBuilder SetApplicationName(this IDataProtectionBuilder builder, string applicationName)
		{
			throw null;
		}

		/// <summary>
		/// Registers a <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink" /> to perform escrow before keys are persisted to storage.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="sink">The instance of the <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink" /> to register.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// Registrations are additive.
		/// </remarks>
		public static IDataProtectionBuilder AddKeyEscrowSink(this IDataProtectionBuilder builder, IKeyEscrowSink sink)
		{
			throw null;
		}

		/// <summary>
		/// Registers a <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink" /> to perform escrow before keys are persisted to storage.
		/// </summary>
		/// <typeparam name="TImplementation">The concrete type of the <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink" /> to register.</typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// Registrations are additive. The factory is registered as <see cref="F:Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton" />.
		/// </remarks>
		public static IDataProtectionBuilder AddKeyEscrowSink<TImplementation>(this IDataProtectionBuilder builder) where TImplementation : class, IKeyEscrowSink
		{
			throw null;
		}

		/// <summary>
		/// Registers a <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink" /> to perform escrow before keys are persisted to storage.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="factory">A factory that creates the <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink" /> instance.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// Registrations are additive. The factory is registered as <see cref="F:Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton" />.
		/// </remarks>
		public static IDataProtectionBuilder AddKeyEscrowSink(this IDataProtectionBuilder builder, Func<IServiceProvider, IKeyEscrowSink> factory)
		{
			throw null;
		}

		/// <summary>
		/// Configures the key management options for the data protection system.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="setupAction">An <see cref="T:System.Action`1" /> to configure the provided <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions" />.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		public static IDataProtectionBuilder AddKeyManagementOptions(this IDataProtectionBuilder builder, Action<KeyManagementOptions> setupAction)
		{
			throw null;
		}

		/// <summary>
		/// Configures the data protection system not to generate new keys automatically.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// Calling this API corresponds to setting <see cref="P:Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions.AutoGenerateKeys" />
		/// to 'false'. See that property's documentation for more information.
		/// </remarks>
		public static IDataProtectionBuilder DisableAutomaticKeyGeneration(this IDataProtectionBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Configures the data protection system to persist keys to the specified directory.
		/// This path may be on the local machine or may point to a UNC share.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="directory">The directory in which to store keys.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		public static IDataProtectionBuilder PersistKeysToFileSystem(this IDataProtectionBuilder builder, DirectoryInfo directory)
		{
			throw null;
		}

		/// <summary>
		/// Configures the data protection system to persist keys to the Windows registry.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="registryKey">The location in the registry where keys should be stored.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		public static IDataProtectionBuilder PersistKeysToRegistry(this IDataProtectionBuilder builder, RegistryKey registryKey)
		{
			throw null;
		}

		/// <summary>
		/// Configures keys to be encrypted to a given certificate before being persisted to storage.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="certificate">The certificate to use when encrypting keys.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		public static IDataProtectionBuilder ProtectKeysWithCertificate(this IDataProtectionBuilder builder, X509Certificate2 certificate)
		{
			throw null;
		}

		/// <summary>
		/// Configures keys to be encrypted to a given certificate before being persisted to storage.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="thumbprint">The thumbprint of the certificate to use when encrypting keys.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		public static IDataProtectionBuilder ProtectKeysWithCertificate(this IDataProtectionBuilder builder, string thumbprint)
		{
			throw null;
		}

		/// <summary>
		/// Configures certificates which can be used to decrypt keys loaded from storage.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="certificates">Certificates that can be used to decrypt key data.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		public static IDataProtectionBuilder UnprotectKeysWithAnyCertificate(this IDataProtectionBuilder builder, params X509Certificate2[] certificates)
		{
			throw null;
		}

		/// <summary>
		/// Configures keys to be encrypted with Windows DPAPI before being persisted to
		/// storage. The encrypted key will only be decryptable by the current Windows user account.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// This API is only supported on Windows platforms.
		/// </remarks>
		public static IDataProtectionBuilder ProtectKeysWithDpapi(this IDataProtectionBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Configures keys to be encrypted with Windows DPAPI before being persisted to
		/// storage.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="protectToLocalMachine">'true' if the key should be decryptable by any
		/// use on the local machine, 'false' if the key should only be decryptable by the current
		/// Windows user account.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// This API is only supported on Windows platforms.
		/// </remarks>
		public static IDataProtectionBuilder ProtectKeysWithDpapi(this IDataProtectionBuilder builder, bool protectToLocalMachine)
		{
			throw null;
		}

		/// <summary>
		/// Configures keys to be encrypted with Windows CNG DPAPI before being persisted
		/// to storage. The keys will be decryptable by the current Windows user account.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// See https://msdn.microsoft.com/en-us/library/windows/desktop/hh706794(v=vs.85).aspx
		/// for more information on DPAPI-NG. This API is only supported on Windows 8 / Windows Server 2012 and higher.
		/// </remarks>
		public static IDataProtectionBuilder ProtectKeysWithDpapiNG(this IDataProtectionBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Configures keys to be encrypted with Windows CNG DPAPI before being persisted to storage.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="protectionDescriptorRule">The descriptor rule string with which to protect the key material.</param>
		/// <param name="flags">Flags that should be passed to the call to 'NCryptCreateProtectionDescriptor'.
		/// The default value of this parameter is <see cref="F:Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiNGProtectionDescriptorFlags.None" />.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// See https://msdn.microsoft.com/en-us/library/windows/desktop/hh769091(v=vs.85).aspx
		/// and https://msdn.microsoft.com/en-us/library/windows/desktop/hh706800(v=vs.85).aspx
		/// for more information on valid values for the the <paramref name="protectionDescriptorRule" />
		/// and <paramref name="flags" /> arguments.
		/// This API is only supported on Windows 8 / Windows Server 2012 and higher.
		/// </remarks>
		public static IDataProtectionBuilder ProtectKeysWithDpapiNG(this IDataProtectionBuilder builder, string protectionDescriptorRule, DpapiNGProtectionDescriptorFlags flags)
		{
			throw null;
		}

		/// <summary>
		/// Sets the default lifetime of keys created by the data protection system.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="lifetime">The lifetime (time before expiration) for newly-created keys.
		/// See <see cref="P:Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions.NewKeyLifetime" /> for more information and
		/// usage notes.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		public static IDataProtectionBuilder SetDefaultKeyLifetime(this IDataProtectionBuilder builder, TimeSpan lifetime)
		{
			throw null;
		}

		/// <summary>
		/// Configures the data protection system to use the specified cryptographic algorithms
		/// by default when generating protected payloads.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="configuration">Information about what cryptographic algorithms should be used.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		public static IDataProtectionBuilder UseCryptographicAlgorithms(this IDataProtectionBuilder builder, AuthenticatedEncryptorConfiguration configuration)
		{
			throw null;
		}

		/// <summary>
		/// Configures the data protection system to use custom Windows CNG algorithms.
		/// This API is intended for advanced scenarios where the developer cannot use the
		/// algorithms specified in the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.EncryptionAlgorithm" /> and
		/// <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ValidationAlgorithm" /> enumerations.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="configuration">Information about what cryptographic algorithms should be used.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// This API is only available on Windows.
		/// </remarks>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static IDataProtectionBuilder UseCustomCryptographicAlgorithms(this IDataProtectionBuilder builder, CngCbcAuthenticatedEncryptorConfiguration configuration)
		{
			throw null;
		}

		/// <summary>
		/// Configures the data protection system to use custom Windows CNG algorithms.
		/// This API is intended for advanced scenarios where the developer cannot use the
		/// algorithms specified in the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.EncryptionAlgorithm" /> and
		/// <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ValidationAlgorithm" /> enumerations.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="configuration">Information about what cryptographic algorithms should be used.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// This API is only available on Windows.
		/// </remarks>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static IDataProtectionBuilder UseCustomCryptographicAlgorithms(this IDataProtectionBuilder builder, CngGcmAuthenticatedEncryptorConfiguration configuration)
		{
			throw null;
		}

		/// <summary>
		/// Configures the data protection system to use custom algorithms.
		/// This API is intended for advanced scenarios where the developer cannot use the
		/// algorithms specified in the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.EncryptionAlgorithm" /> and
		/// <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ValidationAlgorithm" /> enumerations.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <param name="configuration">Information about what cryptographic algorithms should be used.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static IDataProtectionBuilder UseCustomCryptographicAlgorithms(this IDataProtectionBuilder builder, ManagedAuthenticatedEncryptorConfiguration configuration)
		{
			throw null;
		}

		/// <summary>
		/// Configures the data protection system to use the <see cref="T:Microsoft.AspNetCore.DataProtection.EphemeralDataProtectionProvider" />
		/// for data protection services.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.</param>
		/// <returns>A reference to the <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> after this operation has completed.</returns>
		/// <remarks>
		/// If this option is used, payloads protected by the data protection system will
		/// be permanently undecipherable after the application exits.
		/// </remarks>
		public static IDataProtectionBuilder UseEphemeralDataProtectionProvider(this IDataProtectionBuilder builder)
		{
			throw null;
		}
	}
}
