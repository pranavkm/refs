using System;

namespace Microsoft.Extensions.ObjectPool
{
	public class LeakTrackingObjectPool<T> : ObjectPool<T> where T : class
	{
		private class Tracker : IDisposable
		{
			public Tracker()
			{
				throw null;
			}

			public void Dispose()
			{
				throw null;
			}

			~Tracker()
			{
				throw null;
			}
		}

		public LeakTrackingObjectPool(ObjectPool<T> inner)
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
