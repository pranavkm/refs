using System.Runtime.CompilerServices;
using System.Text;

namespace Microsoft.Extensions.ObjectPool
{
	public class StringBuilderPooledObjectPolicy : PooledObjectPolicy<StringBuilder>
	{
		public int InitialCapacity
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

		public int MaximumRetainedCapacity
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

		public override StringBuilder Create()
		{
			throw null;
		}

		public override bool Return(StringBuilder obj)
		{
			throw null;
		}

		public StringBuilderPooledObjectPolicy()
		{
			throw null;
		}
	}
}
