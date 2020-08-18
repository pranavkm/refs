using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	internal sealed class KeyRingBasedDataProtector : IDataProtector, IDataProtectionProvider, IPersistedDataProtector
	{
		private struct AdditionalAuthenticatedDataTemplate
		{
			private sealed class PurposeBinaryWriter : BinaryWriter
			{
				[System.Runtime.CompilerServices.NullableContext(1)]
				public PurposeBinaryWriter(MemoryStream stream)
				{
					throw null;
				}

				public void WriteBigEndian(uint value)
				{
					throw null;
				}
			}

			private byte[] _aadTemplate;

			public AdditionalAuthenticatedDataTemplate(IEnumerable<string> purposes)
			{
				throw null;
			}

			public byte[] GetAadForKey(Guid keyId, bool isProtecting)
			{
				throw null;
			}
		}

		private enum UnprotectStatus
		{
			Ok,
			DefaultEncryptionKeyChanged,
			DecryptionKeyWasRevoked
		}

		internal string[] Purposes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public KeyRingBasedDataProtector(IKeyRingProvider keyRingProvider, ILogger logger, string[] originalPurposes, string newPurpose)
		{
			throw null;
		}

		public IDataProtector CreateProtector(string purpose)
		{
			throw null;
		}

		public byte[] DangerousUnprotect(byte[] protectedData, bool ignoreRevocationErrors, out bool requiresMigration, out bool wasRevoked)
		{
			throw null;
		}

		public byte[] Protect(byte[] plaintext)
		{
			throw null;
		}

		public byte[] Unprotect(byte[] protectedData)
		{
			throw null;
		}
	}
}
