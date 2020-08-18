using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.ObjectPool
{
	/// <summary>
	/// The default <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPoolProvider" />.
	/// </summary>
	public class DefaultObjectPoolProvider : ObjectPoolProvider
	{
		/// <summary>
		/// The maximum number of objects to retain in the pool.
		/// </summary>
		public int MaximumRetained
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override ObjectPool<T> Create<T>(IPooledObjectPolicy<T> policy)
		{
			throw null;
		}

		public DefaultObjectPoolProvider()
		{
			throw null;
		}
	}
}
