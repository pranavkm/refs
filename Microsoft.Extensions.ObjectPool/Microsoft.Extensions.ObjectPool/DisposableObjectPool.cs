using System;

namespace Microsoft.Extensions.ObjectPool
{
	internal sealed class DisposableObjectPool<T> : DefaultObjectPool<T>, IDisposable where T : class
	{
		public DisposableObjectPool(IPooledObjectPolicy<T> policy)
		{
			throw null;
		}

		public DisposableObjectPool(IPooledObjectPolicy<T> policy, int maximumRetained)
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

		public void Dispose()
		{
			throw null;
		}
	}
}
