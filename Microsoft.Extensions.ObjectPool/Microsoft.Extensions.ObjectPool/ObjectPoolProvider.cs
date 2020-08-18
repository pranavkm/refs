namespace Microsoft.Extensions.ObjectPool
{
	/// <summary>
	/// A provider of <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPool`1" /> instances.
	/// </summary>
	public abstract class ObjectPoolProvider
	{
		/// <summary>
		/// Creates an <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPool" />.
		/// </summary>
		/// <typeparam name="T">The type to create a pool for.</typeparam>
		public ObjectPool<T> Create<T>() where T : class, new()
		{
			throw null;
		}

		/// <summary>
		/// Creates an <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPool" /> with the given <see cref="T:Microsoft.Extensions.ObjectPool.IPooledObjectPolicy`1" />.
		/// </summary>
		/// <typeparam name="T">The type to create a pool for.</typeparam>
		public abstract ObjectPool<T> Create<T>(IPooledObjectPolicy<T> policy) where T : class;

		protected ObjectPoolProvider()
		{
			throw null;
		}
	}
}
