namespace Microsoft.Extensions.ObjectPool
{
	public class DefaultPooledObjectPolicy<T> : PooledObjectPolicy<T> where T : class, new()
	{
		public override T Create()
		{
			throw null;
		}

		public override bool Return(T obj)
		{
			throw null;
		}

		public DefaultPooledObjectPolicy()
		{
			throw null;
		}
	}
}
