using Microsoft.Extensions.ObjectPool;

namespace Microsoft.AspNetCore.Routing
{
	internal class UriBuilderContextPooledObjectPolicy : IPooledObjectPolicy<UriBuildingContext>
	{
		public UriBuildingContext Create()
		{
			throw null;
		}

		public bool Return(UriBuildingContext obj)
		{
			throw null;
		}

		public UriBuilderContextPooledObjectPolicy()
		{
			throw null;
		}
	}
}
