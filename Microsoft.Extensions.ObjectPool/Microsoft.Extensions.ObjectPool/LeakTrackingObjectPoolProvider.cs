namespace Microsoft.Extensions.ObjectPool
{
	public class LeakTrackingObjectPoolProvider : ObjectPoolProvider
	{
		public LeakTrackingObjectPoolProvider(ObjectPoolProvider inner)
		{
			throw null;
		}

		public override ObjectPool<T> Create<T>(IPooledObjectPolicy<T> policy)
		{
			throw null;
		}
	}
}
