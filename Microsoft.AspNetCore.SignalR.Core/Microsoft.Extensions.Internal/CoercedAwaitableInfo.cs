using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Internal
{
	internal readonly struct CoercedAwaitableInfo
	{
		public AwaitableInfo AwaitableInfo
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Expression CoercerExpression
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Type CoercerResultType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool RequiresCoercion
		{
			get
			{
				throw null;
			}
		}

		public CoercedAwaitableInfo(AwaitableInfo awaitableInfo)
		{
			throw null;
		}

		public CoercedAwaitableInfo(Expression coercerExpression, Type coercerResultType, AwaitableInfo coercedAwaitableInfo)
		{
			throw null;
		}

		public static bool IsTypeAwaitable(Type type, out CoercedAwaitableInfo info)
		{
			throw null;
		}
	}
}
