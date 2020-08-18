using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal abstract class ResourceCounter
	{
		private class UnlimitedCounter : ResourceCounter
		{
			public override bool TryLockOne()
			{
				throw null;
			}

			public override void ReleaseOne()
			{
				throw null;
			}

			public UnlimitedCounter()
			{
				throw null;
			}
		}

		internal class FiniteCounter : ResourceCounter
		{
			internal long Count
			{
				get
				{
					throw null;
				}
				set
				{
					throw null;
				}
			}

			public FiniteCounter(long max)
			{
				throw null;
			}

			public override bool TryLockOne()
			{
				throw null;
			}

			public override void ReleaseOne()
			{
				throw null;
			}
		}

		public static ResourceCounter Unlimited
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public abstract bool TryLockOne();

		public abstract void ReleaseOne();

		public static ResourceCounter Quota(long amount)
		{
			throw null;
		}

		protected ResourceCounter()
		{
			throw null;
		}
	}
}
