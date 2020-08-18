using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection
{
	internal class RegistryPolicy
	{
		public AlgorithmConfiguration EncryptorConfiguration
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IEnumerable<IKeyEscrowSink> KeyEscrowSinks
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int? DefaultKeyLifetime
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RegistryPolicy(AlgorithmConfiguration configuration, IEnumerable<IKeyEscrowSink> keyEscrowSinks, int? defaultKeyLifetime)
		{
			throw null;
		}
	}
}
