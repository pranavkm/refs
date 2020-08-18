using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.DataProtection.Managed;
using Microsoft.Extensions.Logging;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory" /> for <see cref="T:Microsoft.AspNetCore.DataProtection.Managed.ManagedAuthenticatedEncryptor" />.
	/// </summary>
	public sealed class ManagedAuthenticatedEncryptorFactory : IAuthenticatedEncryptorFactory
	{
		/// <summary>
		/// Contains helper methods for generating cryptographic algorithm factories.
		/// </summary>
		private static class AlgorithmActivator
		{
			private interface IActivator<out T>
			{
				Func<T> Creator
				{
					get;
				}
			}

			private class AlgorithmActivatorCore<T> : IActivator<T> where T : new()
			{
				public Func<T> Creator
				{
					[CompilerGenerated]
					get
					{
						throw null;
					}
				}

				public AlgorithmActivatorCore()
				{
					throw null;
				}
			}

			/// <summary>
			/// Creates a factory that wraps a call to <see cref="M:System.Activator.CreateInstance``1" />.
			/// </summary>
			public static Func<T> CreateFactory<T>(Type implementation)
			{
				throw null;
			}
		}

		public ManagedAuthenticatedEncryptorFactory(ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public IAuthenticatedEncryptor CreateEncryptorInstance(IKey key)
		{
			throw null;
		}

		internal ManagedAuthenticatedEncryptor CreateAuthenticatedEncryptorInstance(ISecret secret, ManagedAuthenticatedEncryptorConfiguration configuration)
		{
			throw null;
		}
	}
}
