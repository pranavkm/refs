using System;
using System.Threading;

namespace Microsoft.Extensions.Internal
{
	internal static class NonCapturingTimer
	{
		public static Timer Create(TimerCallback callback, object? state, TimeSpan dueTime, TimeSpan period)
		{
			throw null;
		}
	}
}
