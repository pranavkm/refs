using System.Text;

namespace Microsoft.Extensions.ObjectPool
{
	public static class ObjectPoolProviderExtensions
	{
		public static ObjectPool<StringBuilder> CreateStringBuilderPool(this ObjectPoolProvider provider)
		{
			throw null;
		}

		public static ObjectPool<StringBuilder> CreateStringBuilderPool(this ObjectPoolProvider provider, int initialCapacity, int maximumRetainedCapacity)
		{
			throw null;
		}
	}
}
