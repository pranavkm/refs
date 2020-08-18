using System.Reflection;

namespace Microsoft.AspNetCore.Hosting
{
	internal static class MethodInfoExtensions
	{
		public static object InvokeWithoutWrappingExceptions(this MethodInfo methodInfo, object obj, object[] parameters)
		{
			throw null;
		}
	}
}
