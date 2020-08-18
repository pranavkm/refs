using System;

namespace Microsoft.AspNetCore.Cryptography
{
	internal static class WeakReferenceHelpers
	{
		public static T GetSharedInstance<T>(ref WeakReference<T> weakReference, Func<T> factory) where T : class, IDisposable
		{
			throw null;
		}
	}
}
