using Microsoft.Extensions.ObjectPool;

namespace Microsoft.AspNetCore.Antiforgery
{
	internal class AntiforgerySerializationContextPooledObjectPolicy : IPooledObjectPolicy<AntiforgerySerializationContext>
	{
		public AntiforgerySerializationContext Create()
		{
			throw null;
		}

		public bool Return(AntiforgerySerializationContext obj)
		{
			throw null;
		}

		public AntiforgerySerializationContextPooledObjectPolicy()
		{
			throw null;
		}
	}
}
