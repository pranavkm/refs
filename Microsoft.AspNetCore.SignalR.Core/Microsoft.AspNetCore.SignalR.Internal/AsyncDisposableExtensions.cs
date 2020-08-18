using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal static class AsyncDisposableExtensions
	{
		public static ValueTask DisposeAsync(this IDisposable disposable)
		{
			throw null;
		}
	}
}
