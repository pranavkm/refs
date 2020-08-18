using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.ObjectPool;

namespace Microsoft.AspNetCore.Antiforgery
{
	internal class DefaultAntiforgeryTokenSerializer : IAntiforgeryTokenSerializer
	{
		public DefaultAntiforgeryTokenSerializer(IDataProtectionProvider provider, ObjectPool<AntiforgerySerializationContext> pool)
		{
			throw null;
		}

		public AntiforgeryToken Deserialize(string serializedToken)
		{
			throw null;
		}

		public string Serialize(AntiforgeryToken token)
		{
			throw null;
		}
	}
}
