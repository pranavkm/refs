using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Contains factory methods for creating an <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" /> where keys are stored
	/// at a particular location on the file system.
	/// </summary>
	/// <remarks>Use these methods when not using dependency injection to provide the service to the application.</remarks>
	public static class DataProtectionProvider
	{
		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.DataProtection.DataProtectionProvider" /> that store keys in a location based on
		/// the platform and operating system.
		/// </summary>
		/// <param name="applicationName">An identifier that uniquely discriminates this application from all other
		/// applications on the machine.</param>
		public static IDataProtectionProvider Create(string applicationName)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.DataProtectionProvider" /> given a location at which to store keys.
		/// </summary>
		/// <param name="keyDirectory">The <see cref="T:System.IO.DirectoryInfo" /> in which keys should be stored. This may
		/// represent a directory on a local disk or a UNC share.</param>
		public static IDataProtectionProvider Create(DirectoryInfo keyDirectory)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.DataProtectionProvider" /> given a location at which to store keys and an
		/// optional configuration callback.
		/// </summary>
		/// <param name="keyDirectory">The <see cref="T:System.IO.DirectoryInfo" /> in which keys should be stored. This may
		/// represent a directory on a local disk or a UNC share.</param>
		/// <param name="setupAction">An optional callback which provides further configuration of the data protection
		/// system. See <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> for more information.</param>
		public static IDataProtectionProvider Create(DirectoryInfo keyDirectory, Action<IDataProtectionBuilder> setupAction)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.DataProtection.DataProtectionProvider" /> that store keys in a location based on
		/// the platform and operating system and uses the given <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> to encrypt the keys.
		/// </summary>
		/// <param name="applicationName">An identifier that uniquely discriminates this application from all other
		/// applications on the machine.</param>
		/// <param name="certificate">The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> to be used for encryption.</param>
		public static IDataProtectionProvider Create(string applicationName, X509Certificate2 certificate)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.DataProtectionProvider" /> given a location at which to store keys
		/// and a <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> used to encrypt the keys.
		/// </summary>
		/// <param name="keyDirectory">The <see cref="T:System.IO.DirectoryInfo" /> in which keys should be stored. This may
		/// represent a directory on a local disk or a UNC share.</param>
		/// <param name="certificate">The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> to be used for encryption.</param>
		public static IDataProtectionProvider Create(DirectoryInfo keyDirectory, X509Certificate2 certificate)
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.DataProtectionProvider" /> given a location at which to store keys, an
		/// optional configuration callback and a <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> used to encrypt the keys.
		/// </summary>
		/// <param name="keyDirectory">The <see cref="T:System.IO.DirectoryInfo" /> in which keys should be stored. This may
		/// represent a directory on a local disk or a UNC share.</param>
		/// <param name="setupAction">An optional callback which provides further configuration of the data protection
		/// system. See <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" /> for more information.</param>
		/// <param name="certificate">The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> to be used for encryption.</param>
		public static IDataProtectionProvider Create(DirectoryInfo keyDirectory, Action<IDataProtectionBuilder> setupAction, X509Certificate2 certificate)
		{
			throw null;
		}

		internal static IDataProtectionProvider CreateProvider(DirectoryInfo? keyDirectory, Action<IDataProtectionBuilder> setupAction, X509Certificate2? certificate)
		{
			throw null;
		}
	}
}
