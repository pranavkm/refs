using System.Diagnostics;

namespace Microsoft.Extensions.ObjectPool
{
	/// <summary>
	/// Default implementation of <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPool`1" />.
	/// </summary>
	/// <typeparam name="T">The type to pool objects for.</typeparam>
	/// <remarks>This implementation keeps a cache of retained objects. This means that if objects are returned when the pool has already reached "maximumRetained" objects they will be available to be Garbage Collected.</remarks>
	public class DefaultObjectPool<T> : ObjectPool<T> where T : class
	{
		[DebuggerDisplay("{Element}")]
		private protected struct ObjectWrapper
		{
			public T? Element;
		}

		private protected readonly ObjectWrapper[] _items;

		private protected readonly IPooledObjectPolicy<T> _policy;

		private protected readonly bool _isDefaultPolicy;

		private protected T? _firstItem;

		private protected readonly PooledObjectPolicy<T>? _fastPolicy;

		/// <summary>
		/// Creates an instance of <see cref="T:Microsoft.Extensions.ObjectPool.DefaultObjectPool`1" />.
		/// </summary>
		/// <param name="policy">The pooling policy to use.</param>
		public DefaultObjectPool(IPooledObjectPolicy<T> policy)
		{
			throw null;
		}

		/// <summary>
		/// Creates an instance of <see cref="T:Microsoft.Extensions.ObjectPool.DefaultObjectPool`1" />.
		/// </summary>
		/// <param name="policy">The pooling policy to use.</param>
		/// <param name="maximumRetained">The maximum number of objects to retain in the pool.</param>
		public DefaultObjectPool(IPooledObjectPolicy<T> policy, int maximumRetained)
		{
			throw null;
		}

		public override T Get()
		{
			throw null;
		}

		public override void Return(T obj)
		{
			throw null;
		}
	}
}
