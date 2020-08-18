using Microsoft.AspNetCore.DataProtection.Internal;
using System;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// A simplified default implementation of <see cref="T:Microsoft.AspNetCore.DataProtection.Internal.IActivator" /> that understands
	/// how to call ctors which take <see cref="T:System.IServiceProvider" />.
	/// </summary>
	internal class SimpleActivator : IActivator
	{
		/// <summary>
		/// A default <see cref="T:Microsoft.AspNetCore.DataProtection.SimpleActivator" /> whose wrapped <see cref="T:System.IServiceProvider" /> is null.
		/// </summary>
		internal static readonly SimpleActivator DefaultWithoutServices;

		public SimpleActivator(IServiceProvider services)
		{
			throw null;
		}

		public virtual object CreateInstance(Type expectedBaseType, string implementationTypeName)
		{
			throw null;
		}
	}
}
