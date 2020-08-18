using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Internal
{
	internal static class ValueTaskExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Task GetAsTask(this in ValueTask<FlushResult> valueTask)
		{
			throw null;
		}
	}
}
