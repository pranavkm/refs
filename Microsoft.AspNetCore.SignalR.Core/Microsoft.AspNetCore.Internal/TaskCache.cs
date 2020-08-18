using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Internal
{
	internal static class TaskCache
	{
		public static readonly Task<bool> True;

		public static readonly Task<bool> False;
	}
}
